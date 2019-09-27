﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using Player;

public class DB_Puzzle : MonoBehaviour {
    
    public List<Item> requirements;
    public enum RequirementsIndexing {Screwdriver = 0, Wires = 1, Switch = 2}


    public List<Image> requirementsCheckboxes;

    public Sprite acquiredCheck;
    public Sprite missingCheck;

    public GameObject ButtonPrompt;
    public GameObject puzzleUI;
    public Transform ReferencePosition;

    protected PlayerManager manager;
    protected Vector3 defaultPosition;

    #region Front Cover Section

        [Header("Front Cover Section")]
            public Transform theCover;
            public enum CoverCondition { Fixed = 0, Loose = 1, Off = 2}
            public CoverCondition currentCoverState = CoverCondition.Fixed;

            private int numScrews = 4;
            public void RemoveScrew () {
                if (!PlayerReference.instance.PlayerInventory.Contains(requirements[(int)RequirementsIndexing.Screwdriver])) {
                    // No Screwdriver, this is impossible
                    return;
                }
                if (currentCoverState != CoverCondition.Fixed) {
                    return;
                } 
                numScrews--;
                if (numScrews == 0) {
                    currentCoverState = CoverCondition.Loose;
                }
            }

            public void RemoveCover () {
                if (currentCoverState != CoverCondition.Loose) {
                    return;
                }

                currentCoverState = CoverCondition.Off;
                SetCoverState();
            }
            [SerializeField] protected Vector3 offPosition;
            [SerializeField] protected Vector3 onPosition;
            
    #endregion

    #region Removing the Switch 
        [Header("Removing the Switch")]
            public Transform theTopCable;
            public Transform theBottomCable;
            public Transform theSwitch;

            public enum SwitchCondition { Fixed = 0, Partial = 1, Loose = 2, Removed = 3}
            public SwitchCondition currentSwitchState = SwitchCondition.Fixed;

            public void RemoveWire() {
                if (currentCoverState != CoverCondition.Off) {
                    return;
                }

                if (currentSwitchState == SwitchCondition.Removed) {
                    return;
                }

                currentSwitchState++;
                SetSwitchState();
            }
    #endregion

    #region Adding the New Switch 
        [Header("Adding the New Switch")]
            public Transform theNewSwitch;
            public bool SwitchInstalled = false;


        public void PlaceNewSwitch () {
            if (!PlayerReference.instance.PlayerInventory.Contains(requirements[(int)RequirementsIndexing.Switch])) {
                return;
            }

            if (SwitchInstalled || currentSwitchState != SwitchCondition.Removed) {
                return;
            }

            SwitchInstalled = true;
            SetSwitchState();
        }


    #endregion

    #region The New Wires 
        [Header("The New Wires")]
            public Transform DemonstrationWireRight;
            public Transform DemonstrationWireLeft;

            
    #endregion
    

    public int puzzleState = 0;

    private void Start() {
        manager = PlayerReference.instance.manager;
        defaultPosition = this.transform.position;
    }
    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            PlayerReference.instance.dB_Puzzle = this;
            manager.OnInteractEnter += Interact;
            ButtonPrompt.SetActive(true);
        }
    }   

     private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            PlayerReference.instance.dB_Puzzle = null;
            manager.OnInteractEnter -= Interact;
            ButtonPrompt.SetActive(false);
        }
    }   

    public void Interact () {
        puzzleUI.SetActive(true);
        transform.position = ReferencePosition.position;

        SetCoverState();
        SetSwitchState();
    }

    private void SetCoverState () {
        theCover.localPosition = currentCoverState == CoverCondition.Off ? offPosition : onPosition;
    }

    private void SetSwitchState() {
        theSwitch.gameObject.SetActive(currentSwitchState < SwitchCondition.Removed);
        theBottomCable.gameObject.SetActive(currentSwitchState < SwitchCondition.Loose);
        theTopCable.gameObject.SetActive(currentSwitchState < SwitchCondition.Partial);

        theNewSwitch.gameObject.SetActive(SwitchInstalled);
    }



    public void ClosePuzzle () {
        puzzleUI.SetActive(false);
        transform.position = defaultPosition;
    }

    public bool CheckRequirements() {
        bool result = true;
        int index = 0;
        foreach (Item item in requirements) {
            bool currentStatus = PlayerReference.instance.PlayerInventory.Contains(item);

            requirementsCheckboxes[index].sprite = currentStatus ? acquiredCheck : missingCheck;

            result = result && currentStatus;
            index ++;
        }
        
        return result;
    }

}
