using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Examine State", menuName = "Player State/Examine")]
    public class Examine : States {
        
        [SerializeField] protected GameObject ExamineUI;
        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;

            PlayerObject = PlayerReference.instance.manager;
            ExamineUI = PlayerReference.instance.examineUI;

            controls.Examining.Exit.performed += ctx => ExitState();
            controls.Examining.Pause.performed += ctx => Pause();
        }

        public override void Step() {
            
        }

        public override void EnableState() {
            controls.Examining.Enable();
            ExamineUI.SetActive(true);
        }

        public override void DisableState() {
            controls.Examining.Disable();
            ExamineUI.SetActive(false);
        }

        private void ExitState () {
            PlayerObject.SetState(PreviousState);
        }
    }
}