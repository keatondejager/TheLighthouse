using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Player;

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

        private PlayerInputActions controls;
    
    [Header("Combination Control")]
        [Range(1000, 9999)] [SerializeField] protected int correctCombination = 1000;
        [SerializeField] protected int SolutionAttempt = 0; 

        [SerializeField] protected int IndexMultiplier = 1;
        [SerializeField] protected int Index = 0;



    private void Start() {
        isLocked = true;
        whichFunction = 0;

        controls = new PlayerInputActions();

        controls.PuzzleControls.PrimaryButton.performed += ctx => CheckCombination();
        controls.PuzzleControls.Close.performed += ctx => ExitButtonPressed ();

        controls.PuzzleControls.RightToggle.started += ctx => CursorRight();
        controls.PuzzleControls.LeftToggle.started += ctx => CursorLeft();

        controls.PuzzleControls.DigitDown.started += ctx => DigitDown();
        controls.PuzzleControls.DigitUp.started += ctx => DigitUp();
    }

    private void OnTriggerEnter(Collider other) {
        var obj = other.GetComponent<PlayerManager>();
        if (obj is PlayerManager) {
            if (!manager) {
                manager = obj;
            }

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

            ButtonPrompt.SetActive(whichFunction != 0);
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
        Debug.Log ("Open the Puzzle"); 
        PlayerReference.instance.combinationLock = this;
        
    }

    private void OpenDoor () {  
        // Play end of game cutscene
        
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
        controls.PuzzleControls.Enable();
    }

    public void ClosePuzzleUI () {
        UI_Prompts.SetActive(false);
        controls.PuzzleControls.Disable();
    }

    private void CheckCombination () {
        if (SolutionAttempt == correctCombination) {
            Debug.Log("correct");
        } else {
            Debug.Log("no");
        }
    }

    private void DigitDown () {
        int leftovers = SolutionAttempt % IndexMultiplier;
        int activeDigit = SolutionAttempt - leftovers;
        SolutionAttempt -= activeDigit;
        activeDigit /= IndexMultiplier;
        

        activeDigit--; 
        if (activeDigit < 0) {
            activeDigit = 9;
        }

        digitDisplay[Index].text = activeDigit.ToString();  
    }

    private void DigitUp () {
        int leftovers = SolutionAttempt % IndexMultiplier; // 1919 % 1000 = 919
        int activeDigit = SolutionAttempt - leftovers;  // 1919 - 919 = 1000
        SolutionAttempt -= activeDigit; // 1919 - 1000 = 919
        activeDigit /= IndexMultiplier; //1000 / 1000 = 1

        activeDigit++; // 1 + 1 = 2
        if (activeDigit > 9) { 
            activeDigit = 0;
        }

        digitDisplay[Index].text = activeDigit.ToString(); // Text gets 2

        activeDigit *= IndexMultiplier; // 2 * 1000 = 2000
        SolutionAttempt += activeDigit; // 919 + 2000 = 2919
    }


    private void CursorRight () {
        Index++;
        IndexMultiplier *= 10;
        if (IndexMultiplier > 1000) {
            IndexMultiplier = 1;
            Index = 0;
        }  
    }

    private void CursorLeft ()  {
        Index--;
        if (IndexMultiplier == 1) {
            IndexMultiplier = 10000;
            Index = digitDisplay.Count - 1;
        }
        IndexMultiplier /= 10;
    }

    private void ExitButtonPressed () {
        manager.UniversalExit();
    }
}
