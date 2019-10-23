using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistributionBoard : MonoBehaviour
{
    [Header("State Control")]
        [SerializeField] protected Player.Puzzle playerState;

        [SerializeField] protected DB_State activeState;
        [SerializeField] protected List<DB_State> allStates;
        [SerializeField] protected int stateIndex;
        [SerializeField] protected bool isEnabled;

        [Space]
        [SerializeField] protected EmptyState Standby;

        [Space]
        [SerializeField] protected bool hasInteracted;
        [SerializeField] protected int NarrativeCueIndex;
        [SerializeField] protected int CompletePuzzleIndex;
        [SerializeField] protected GameObject CheckList;
        [SerializeField] protected float checklistDelay = 2f;
        [SerializeField] protected float impatientTime = 5f;

        [Space]
        [SerializeField] protected LightManager puzzleResult;
        
        [Space]
        [SerializeField] protected Panel panelObj;
        [SerializeField] protected GameObject ScrewObject1;
        [SerializeField] protected GameObject ScrewObject2;

    [Header("UI Reference")]
        [SerializeField] protected GameObject UIObject;
        [SerializeField] protected Transform PuzzleObjects;
        [SerializeField] protected Transform ReferencePoint;
        private Vector3 originalPosition;
        private Quaternion originalRotation;

        private float doSecondLineDelay = -1f;

    // Start is called before the first frame update
    void Start()
    {   
        InitializeControllers();
        activeState = Standby;
        Standby.ActualState = 0;         
    }

    public void OpenPuzzle () {
        UIObject.SetActive(true);
        originalPosition = PuzzleObjects.position;
        originalRotation = PuzzleObjects.rotation;
        PuzzleObjects.position = ReferencePoint.position;
        PuzzleObjects.rotation = ReferencePoint.rotation;
        
        if (activeState == Standby && Standby.GetState() >= 0) {
            if (!hasInteracted) {
                NarrativeController.instance.TriggerNarrative(NarrativeCueIndex);
            }
            if (allStates[Standby.GetState()].CheckRequirement()){
                activeState = allStates[Standby.GetState()];
            } else {
                if (hasInteracted) {
                    NarrativeController.instance.TriggerNarrative( allStates[Standby.GetState()].RepeatableNarrativeCueIndex );
                } else {
                    doSecondLineDelay = Time.time + checklistDelay + impatientTime;
                }
            }
        }
        

        if (!hasInteracted) {
            Invoke("TurnOnCheckList", checklistDelay);
        }
        hasInteracted = true;
        
        isEnabled = true;
        if  (activeState) {
            activeState.gameObject.SetActive(true);
        } 
    }

    private void TurnOnCheckList() {
        CheckList.SetActive(hasInteracted);
    }

    public void ClosePuzzle() {
        UIObject.SetActive(false);
        PuzzleObjects.position = originalPosition;
        PuzzleObjects.rotation = originalRotation;

        isEnabled = false;
        InitializeControllers(false);
    }

    private void InitializeControllers (bool firstTime = true) {
        foreach(DB_State item in allStates) {
            if (firstTime) {
                item.Initialize(this);
            }
            item.gameObject.SetActive(false);
        }
    }

    private void Update() {
        if (!isEnabled) {
            return;
        }

        if (doSecondLineDelay != -1) {
            if (!isEnabled) {
                doSecondLineDelay = -1f;
            } else if (doSecondLineDelay < Time.time) {
                NarrativeController.instance.TriggerNarrative( allStates[Standby.GetState()].RepeatableNarrativeCueIndex );
                doSecondLineDelay = -1;
            }
        }

        if (activeState) {
            activeState.Step();
        }
    }

    public void StateComplete() {
        activeState.gameObject.SetActive(false);
        activeState = null;
        stateIndex++;
        if (stateIndex < allStates.Count) {
            Standby.ActualState = stateIndex;
            activeState = allStates[stateIndex];

            if (activeState.CheckRequirement()) {
                if (isEnabled) {
                    activeState.gameObject.SetActive(true);
                }
            } else {
                activeState = Standby;
                doSecondLineDelay = Time.time + 0.5f;
            }

            
        } else { 
            Standby.ActualState = -1;
            CompletePuzzle();
            CheckList.SetActive(false);
        }
    }

    private void CompletePuzzle () {
        if (puzzleResult)
                puzzleResult.TurnLightsOn();

        panelObj.gameObject.SetActive(true);
        panelObj.CloseBox();
        panelObj.gameObject.SetActive(false);

        ScrewObject1.SetActive(true);
        ScrewObject2.SetActive(false);

        Player.PlayerReference.instance.puzzleOneComplete = true;
        NarrativeController.instance.TriggerNarrative(CompletePuzzleIndex);

        playerState.ExitState();
    }


}
