using UnityEngine;

namespace Player {

    [CreateAssetMenu(fileName = "Inventory State", menuName = "Player State/Inventory")]
    public class Inventory : States {

        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
            PlayerObject = PlayerReference.instance.manager;
            controls.Inventory.Exit.performed += ctx => ExitState();
            controls.Inventory.Pause.performed += ctx => Pause();
        }

        public override void Step() {

        }

        public override void EnableState() {
            controls.Inventory.Enable();
        }

        public override void DisableState() {
            controls.Inventory.Disable();
        }

    }

}

