using UnityEngine;

namespace Player {
    [CreateAssetMenu(fileName = "Menu State", menuName = "Player State/Menu")]
    public class Menus : States {
        [SerializeField] protected Movement _moveState;
        [SerializeField] protected GameObject MenuObject;
        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
            PlayerObject = PlayerReference.instance.manager;
            MenuObject = PlayerReference.instance.menuObject;
            controls.Menus.Exit.performed += ctx => ExitState();
        }

        public override void Step() {

        }

        public override void EnableState() {
            controls.Menus.Enable();
            MenuObject.SetActive(true);
        }

        public override void DisableState() {
            controls.Menus.Disable();
            MenuObject.SetActive(false);
        }

        public void ExitState () {
            PlayerObject.SetState(_moveState);
        }
    }
}