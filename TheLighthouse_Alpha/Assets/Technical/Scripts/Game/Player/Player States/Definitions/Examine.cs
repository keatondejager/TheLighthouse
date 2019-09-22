using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Examine State", menuName = "Player State/Examine")]
    public class Examine : States {
        
        [SerializeField] protected GameObject ExamineUI;
        [SerializeField] protected Vector2 rotationInput;
        [SerializeField] protected Vector2 zoomInput;

        [Header("State Controls")]
            public Transform objectBeingExamined;
            public Transform ExamineReferencePoint;
            [Range(1, 50)] [SerializeField] protected float rotationSpeed = 1f;
            private Vector3 originalPosition;
            private Quaternion originalRotation;
            

        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;

            PlayerObject = PlayerReference.instance.manager;
            ExamineUI = PlayerReference.instance.examineUI;
            ExamineReferencePoint = PlayerReference.instance.ExamineRefPoint;

            controls.Examining.Exit.performed += ctx => ExitState();
            controls.Examining.Pause.performed += ctx => Pause();

            controls.Examining.Rotate.performed += ctx => rotationInput = ctx.ReadValue<Vector2>();
            controls.Examining.Rotate.canceled += ctx => rotationInput = Vector2.zero;

            controls.Examining.Zoom.performed += ctx => zoomInput = ctx.ReadValue<Vector2>();
            controls.Examining.Zoom.canceled += ctx => zoomInput = Vector2.zero;
        }

        public override void Step() {
            Vector3 _rotation = Vector3.up * rotationInput.x + Vector3.right * rotationInput.y;
            _rotation *= Time.deltaTime;

            objectBeingExamined.Rotate(_rotation * rotationSpeed, Space.World);
        }

        public override void EnableState() {
            controls.Examining.Enable();
            ExamineUI.SetActive(true);
            objectBeingExamined = PlayerReference.instance.examineObject;
            originalPosition = objectBeingExamined.position;
            originalRotation = objectBeingExamined.rotation;
            objectBeingExamined.position = ExamineReferencePoint.position;
            objectBeingExamined.rotation = ExamineReferencePoint.rotation;
        }

        public override void DisableState() {
            objectBeingExamined.position = originalPosition;
            objectBeingExamined.rotation = originalRotation;
            controls.Examining.Disable();
            ExamineUI.SetActive(false);
        }

        private void ExitState () {
            PlayerObject.SetState(PreviousState);
        }
    }
}