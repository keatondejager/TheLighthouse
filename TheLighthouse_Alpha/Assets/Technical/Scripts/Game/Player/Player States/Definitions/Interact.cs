﻿using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    [CreateAssetMenu(fileName = "Interaction State", menuName = "Player State/Interact")]
    public class Interact : States {

        [Header("Object Reference")]
            [SerializeField] protected Animator _animator;
            [SerializeField] protected ButtonNavigation interactableUIControl;
            public GameObject SearchUIObject;

            private SearchableObjectData activeData;
            
            
        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
            PlayerObject = PlayerReference.instance.manager;
            
            SearchUIObject = PlayerReference.instance.searchingUI;
            interactableUIControl = SearchUIObject.GetComponentInChildren<ButtonNavigation>();

            controls.Interact.Exit.performed += ctx => ExitState();
            controls.Interact.Pause.performed += ctx => Pause();
        }

        public override void Step() {
           
        }

        public override void EnableState() {
            controls.Interact.Enable();
            SearchUIObject.SetActive(true);

            activeData = PlayerReference.instance.objectInventory;
            
            ResetDisplay();
        }

        private void ResetDisplay() {
            foreach (UI_Item menuItem in PlayerReference.instance.objectsInGame) {
                if (activeData.inventory.Contains(menuItem.content)) {
                    menuItem.gameObject.SetActive(true);
                } else {
                    menuItem.gameObject.SetActive(false);
                }
            }

            if (activeData.inventory.Count == 0) {
                return;
            }

            //interactableUIControl.defaultIndex = activeData.inventory[0].itemCode;
            interactableUIControl.ActivateDefault();
        }

        public override void DisableState() {
            controls.Interact.Disable();
            SearchUIObject.SetActive(false);
        }

        public void ExitState () {
            PlayerObject.SetState(PreviousState);
        }

        public void TakeItem (int itemID) {
            activeData.RemoveItem(PlayerReference.instance.objectsInGame[itemID].content);
            PlayerReference.instance.PlayerInventory.Add(PlayerReference.instance.objectsInGame[itemID].content);

            ResetDisplay();
        }

    }
}
