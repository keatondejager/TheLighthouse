using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Examine State", menuName = "Player State/Examine")]
    public class Examine : States {
    

        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
        }

        public override void Step() {
            
        }

        public override void EnableState() {
            controls.Examining.Enable();
        }

        public override void DisableState() {
            controls.Examining.Disable();
        }
    }
}