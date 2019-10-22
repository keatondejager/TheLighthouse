using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Player;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class DoorLock : MonoBehaviour
{
    [Header("Door State")]
        [SerializeField] protected bool isLocked = true;

    [Header("Reference")]
        [SerializeField] protected GameObject ButtonPrompt;
        [SerializeField] protected PlayerManager manager;
        [SerializeField] protected int whichFunction = 0;
        [Space]
        [SerializeField] protected Transform UIObject;
        [SerializeField] protected GameObject UI_Prompts;
        [SerializeField] protected GameObject InGameObject;
        [Space]
        [SerializeField] protected List<TMP_Text> digitDisplay;
        [SerializeField] protected GameObject Indicator;
        [Space]
        [SerializeField] protected float emphasisFontSize; 
        [SerializeField] protected float normalFontSize;

        private PlayerInputActions controls;
    
    [Header("Combination Control")]
        [SerializeField] protected List<int> correctCombination;
        [SerializeField] protected List<int> SolutionAttempt; 

        [SerializeField] protected int IndexMultiplier;
        [SerializeField] protected int Index = 0;

    [Header("Feedback")]
        [Range(0.1f, 1f)] [SerializeField] protected float vibrateInterval = 0.2f;
        [Range(0.1f, 1f)] [SerializeField] protected float vibrateDuration = 0.2f;
        [SerializeField] protected int vibrationIterations = 2;
        [Range(0, 1)] [SerializeField] protected float lowFreqIntensity= 0.3f;
        [Range(0, 1)] [SerializeField] protected float highFreqIntensity= 0.3f;

    [Header("Narrative Indices")]
        [SerializeField] protected int OpenPuzzleIndex;
        [SerializeField] protected int WrongCombinationNarrative;
        [SerializeField] protected int correctCombinationNarrative;
        [SerializeField] protected int leaveBeforeSolveIndex;
        [SerializeField] protected int leaveRepeated;


    private void Start() {
        isLocked = true;
        whichFunction = 0;

        controls = new PlayerInputActions();

        SolutionAttempt = new List<int>();

        for (int i = 0; i < 4; i++) {
            SolutionAttempt.Add(0);
        }

        if (normalFontSize == 0) {
            normalFontSize = digitDisplay[0].fontSize;
        }

        controls.PuzzleControls.PrimaryButton.performed += ctx => CheckCombination(ctx.control.path);

        controls.PuzzleControls.RightToggle.started += ctx => CursorRight();
        controls.PuzzleControls.LeftToggle.started += ctx => CursorLeft();

        controls.PuzzleControls.DigitDown.started += ctx => DigitDown();
        controls.PuzzleControls.DigitUp.started += ctx => DigitUp();

        MoveIndicator();
    }

    private void OnTriggerEnter(Collider other) {
        var obj = other.GetComponent<PlayerManager>();
        if (obj is PlayerManager) {
            if (!manager) {
                manager = obj;
            }

            SetFunction();

            ButtonPrompt.SetActive(whichFunction != 0);
        }
    }

    private void SetFunction () {
        if (isLocked) {
                // Open Puzzle Dialogue
                if (whichFunction == 0) {
                    whichFunction = 1;
                    manager.OnInteractEnter += OpenPuzzle;
                    PlayerReference.instance.combinationLock = this;
                } 
            } else {
                // Open Door
                if (whichFunction != -1) {
                    manager.OnInteractEnter += OpenDoor;
                    if (whichFunction == 1) {
                        manager.OnInteractEnter -= OpenPuzzle;
                    }
                    whichFunction = -1;
                }
            }
    }

    private void OnTriggerExit(Collider other) {
        var obj = other.GetComponent<PlayerManager>();
        if (obj is PlayerManager) {
            if (!manager) {
                manager = obj;
            }

            if (whichFunction == 1) {
                manager.OnInteractEnter -= OpenPuzzle;
            } else if (whichFunction == -1) {
                manager.OnInteractEnter -= OpenDoor;
            }

            whichFunction = 0;
            PlayerReference.instance.combinationLock = null;

        }
        ButtonPrompt.SetActive(whichFunction != 0);
    }

    private void OpenPuzzle () {
        // Switch player to puzzle state and open puzzle controller
        PlayerReference.instance.combinationLock = this;
        NarrativeController.instance.TriggerNarrative(OpenPuzzleIndex);
    }

    private void OpenDoor () {  
        // Play end of game cutscene
        SceneManager.LoadScene(2);
    }

    private void OnDisable() {
        if (manager) {
            if (whichFunction == 1) {
                manager.OnInteractEnter -= OpenPuzzle;
            } else if (whichFunction == -1) {
                manager.OnInteractEnter -= OpenDoor;
            } 

            whichFunction = 0;
        }
        controls.PuzzleControls.Disable();
    }

    public void OpenPuzzleUI () {
        UI_Prompts.SetActive(true);
        digitDisplay[Index].fontSize = emphasisFontSize;
        controls.PuzzleControls.Enable();
        MoveIndicator();
    }

    public void ClosePuzzleUI () {
        UI_Prompts.SetActive(false);
        digitDisplay[Index].fontSize = normalFontSize;
        if (isLocked && !PlayerReference.instance.hasInteractedWithDoor) {
            PlayerReference.instance.hasInteractedWithDoor = true;
            NarrativeController.instance.TriggerNarrative(leaveBeforeSolveIndex);
        } else if (isLocked) {
            NarrativeController.instance.TriggerNarrative(leaveRepeated);
        }
        controls.PuzzleControls.Disable();
    }

    private void CheckCombination (string contextPath) {
        bool result = true;
        int count = 0;
        foreach (int digit in SolutionAttempt) {
            result = result && digit == correctCombination[count];
            count++;    
        }
        if (result) {
            PlayerReference.instance.puzzleTwoComplete = true;
            isLocked = false;
            NarrativeController.instance.TriggerNarrative(correctCombinationNarrative);
            SetFunction();
            ExitButtonPressed();
        } else {   
            Player.PlayerReference.instance.ShakeController(contextPath, vibrationIterations, vibrateDuration,
                                                            vibrateInterval, lowFreqIntensity, highFreqIntensity);
            NarrativeController.instance.TriggerNarrative(WrongCombinationNarrative);
        }
    }

    

    private void DigitDown () {
        SolutionAttempt[Index]--;
        if (SolutionAttempt[Index] < 0) {
            SolutionAttempt[Index] = 9;
        }

        digitDisplay[Index].text = SolutionAttempt[Index].ToString();
    }

    private void DigitUp () {
        SolutionAttempt[Index]++;
        if (SolutionAttempt[Index] > 9) {
            SolutionAttempt[Index] = 0;
        }

        digitDisplay[Index].text = SolutionAttempt[Index].ToString();
    }


    private void CursorRight () {
        digitDisplay[Index].fontSize = normalFontSize;
         Index++; 
         if (Index >= SolutionAttempt.Count) {
             Index = 0;
         }
         digitDisplay[Index].fontSize = emphasisFontSize;
         MoveIndicator();
    }

    private void CursorLeft () {
        digitDisplay[Index].fontSize = normalFontSize;
        Index--;
        if (Index < 0) {
            Index = SolutionAttempt.Count - 1;
        }
        digitDisplay[Index].fontSize = emphasisFontSize;
        MoveIndicator();
    }

    private void MoveIndicator() {
        Vector3 position = Indicator.transform.position;
        position.x = digitDisplay[Index].transform.position.x;
        Indicator.transform.position = position;
    }

    private void ExitButtonPressed() {
        PlayerReference.instance.manager.PuzzleExit();
    }

}
