using UnityEngine;

namespace Player {
    [CreateAssetMenu(fileName = "Menu State", menuName = "Player State/Menu")]
    public class Menus : States {
        [SerializeField] protected Movement _moveState;
        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
            PlayerObject = PlayerReference.instance.manager;
            controls.Menus.Exit.performed += ctx => ExitState();
        }

        public override void Step() {

        }

        public override void EnableState() {
            controls.Menus.Enable();
        }

        public override void DisableState() {
            controls.Menus.Disable();
        }

        private void ExitState () {
            PlayerObject.SetState(_moveState);
        }
    }
}