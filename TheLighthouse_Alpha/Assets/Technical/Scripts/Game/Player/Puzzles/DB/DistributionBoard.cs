﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistributionBoard : MonoBehaviour
{
    [Header("State Control")]
        [SerializeField] protected DB_State activeState;
        [SerializeField] protected List<DB_State> allStates;
        [SerializeField] protected int stateIndex;
        [SerializeField] protected bool isEnabled;

        [SerializeField] protected EmptyState Standby;

        [SerializeField] protected bool hasInteracted;
        [SerializeField] protected int NarrativeCueIndex;
        [SerializeField] protected GameObject CheckList;
        [SerializeField] protected float checklistDelay = 2f;

    [Header("UI Reference")]
        [SerializeField] protected GameObject UIObject;
        [SerializeField] protected Transform PuzzleObjects;
        [SerializeField] protected Transform ReferencePoint;
        private Vector3 originalPosition;
        private Quaternion originalRotation;

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
            if (allStates[Standby.GetState()].CheckRequirement()){
                activeState = allStates[Standby.GetState()];
            } else {
                if (hasInteracted)
                    NarrativeController.instance.TriggerNarrative( allStates[Standby.GetState()].RepeatableNarrativeCueIndex );
                else 
                    NarrativeController.instance.TriggerNarrative(NarrativeCueIndex);
            }
        }
        

        if (!hasInteracted) {
            Invoke("TurnOnCheckList", checklistDelay);
        }
        hasInteracted = true;
        
        
        if  (activeState) {
            activeState.gameObject.SetActive(true);
            isEnabled = true;
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
            }

            
        } else { 
            Standby.ActualState = -1;
        }
    }


}
