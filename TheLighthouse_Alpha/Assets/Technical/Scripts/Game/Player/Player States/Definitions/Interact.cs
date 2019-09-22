using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    [CreateAssetMenu(fileName = "Interaction State", menuName = "Player State/Interact")]
    public class Interact : States {

        [Header("Object Reference")]
            [SerializeField] protected Animator _animator;
        //Matt added this (I dont know how to make interact distinguish between Search and open door for example.
        [SerializeField] protected GameObject SearchUI;
        [SerializeField] protected SearchableObject ObjectBeingSearched;

        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
            PlayerObject = PlayerReference.instance.manager;
            //Matt added
            SearchUI = PlayerReference.instance.searchUI;
            //end of matts addition

            controls.Interact.Exit.performed += ctx => ExitState();
            controls.Interact.Pause.performed += ctx => Pause();
        }

        public override void Step() {
           
        }

        public override void EnableState() {
            controls.Interact.Enable();

            //Matt's search non-sense
            SearchUI.SetActive(true);
            ObjectBeingSearched = PlayerReference.instance.searchObject;
            ObjectBeingSearched.Open();
        }

        public override void DisableState() {
            controls.Interact.Disable();
            //Matt's search non-sense
            ObjectBeingSearched = PlayerReference.instance.searchObject;
            ObjectBeingSearched.Close();
            SearchUI.SetActive(false);
        }

        private void ExitState () {
            Debug.Log("we are exiting interact");
            PlayerObject.SetState(PreviousState);
        }
    }
}
