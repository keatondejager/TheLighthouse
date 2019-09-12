using UnityEngine;

namespace Player {

    [CreateAssetMenu(fileName = "Inventory State", menuName = "Player State/Inventory")]
    public class Inventory : States {

        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
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

