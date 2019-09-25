﻿using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    [CreateAssetMenu(fileName = "Interaction State", menuName = "Player State/Interact")]
    public class Interact : States {

        [Header("Object Reference")]
            [SerializeField] protected Animator _animator;
            public GameObject SearchUIObject;

            private SearchableObjectData activeData;
            
        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
            PlayerObject = PlayerReference.instance.manager;
            
            SearchUIObject = PlayerReference.instance.searchingUI;

            controls.Interact.Exit.performed += ctx => ExitState();
            controls.Interact.Pause.performed += ctx => Pause();
        }

        public override void Step() {
           
        }

        public override void EnableState() {
            controls.Interact.Enable();
            SearchUIObject.SetActive(true);

            activeData = PlayerReference.instance.objectInventory;
            
            foreach (UI_Item menuItem in PlayerReference.instance.objectsInGame) {
                if (activeData.inventory.Contains(menuItem.content)) {
                    menuItem.gameObject.SetActive(true);
                } else {
                    menuItem.gameObject.SetActive(false);
                }
            }
        }

        public override void DisableState() {
            controls.Interact.Disable();
            SearchUIObject.SetActive(false);
        }

        public void ExitState () {
            PlayerObject.SetState(PreviousState);
        }
    }
}
