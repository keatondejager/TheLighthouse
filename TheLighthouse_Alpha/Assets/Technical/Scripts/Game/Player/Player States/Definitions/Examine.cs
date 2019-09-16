using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Examine State", menuName = "Player State/Examine")]
    public class Examine : States {
    
        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
            PlayerObject = PlayerReference.instance.manager;
            controls.Examining.Exit.performed += ctx => ExitState();
            controls.Examining.Pause.performed += ctx => Pause();
        }

        public override void Step() {
            
        }

        public override void EnableState() {
            controls.Examining.Enable();
        }

        public override void DisableState() {
            controls.Examining.Disable();
        }

        private void ExitState () {
            PlayerObject.SetState(PreviousState);
        }
    }
}