using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    [CreateAssetMenu(fileName = "Interaction State", menuName = "Player State/Interact")]
    public class Interact : States {

        [Header("Object Reference")]
            [SerializeField] protected Animator _animator;
        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
            PlayerObject = PlayerReference.instance.manager;
            controls.Interact.Exit.performed += ctx => ExitState();
            controls.Interact.Pause.performed += ctx => Pause();
        }

        public override void Step() {
           
        }

        public override void EnableState() {
            controls.Interact.Enable();
        }

        public override void DisableState() {
            controls.Interact.Disable();
        }

        private void ExitState () {
            PlayerObject.SetState(PreviousState);
        }
    }
}
