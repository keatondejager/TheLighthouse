using UnityEngine;
using Environment;
using TMPro;

namespace Player
{
    [CreateAssetMenu(fileName = "Examine State", menuName = "Player State/Examine")]
    public class Examine : States {
        
        [SerializeField] protected GameObject ExamineUI;
        [SerializeField] protected Vector2 rotationInput;
        [SerializeField] protected Vector2 zoomInput;

        [Header("State Controls")]
            public ExamineObjectData objectBeingExamined;
            public Transform ExamineReferencePoint;
            [Range(1, 50)] [SerializeField] protected float rotationSpeed = 1f;
            [Range(1, 3)] [SerializeField] protected float maxZoomDistance = 1f;
            private Vector3 originalPosition;
            private Quaternion originalRotation;
            [SerializeField] private float zoomDistance;
            [Range(1, 10)] [SerializeField] protected float zoomSpeed = 1f;

        private TMP_Text objectName;
            

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

            objectName = PlayerReference.instance.examineObjectName;
        }

        public override void Step() {
            Vector3 _rotation = Vector3.up * rotationInput.x + Vector3.right * rotationInput.y;

            _rotation *= Time.deltaTime;

            objectBeingExamined.ObjectMesh.Rotate(_rotation * rotationSpeed, Space.World);

            float zoomChange = zoomInput.y * Time.deltaTime * zoomSpeed;

            if (zoomDistance + zoomChange > maxZoomDistance) {
                zoomDistance = maxZoomDistance;
            } else if (zoomDistance + zoomChange < -maxZoomDistance) {
                zoomDistance = -maxZoomDistance;
            } else {
                zoomDistance += zoomChange;
            }

            objectBeingExamined.ObjectMesh.position = ExamineReferencePoint.position + Vector3.forward * zoomDistance;

            
        }

        public override void EnableState() {
            controls.Examining.Enable();
            ExamineUI.SetActive(true);

            
            objectBeingExamined = PlayerReference.instance.examineObject;
            objectName.text = objectBeingExamined.ObjectName;

            originalPosition = objectBeingExamined.ObjectMesh.position;
            originalRotation = objectBeingExamined.ObjectMesh.rotation;

            objectBeingExamined.ObjectMesh.position = ExamineReferencePoint.position;
            objectBeingExamined.ObjectMesh.rotation = Quaternion.Euler(objectBeingExamined.StartingRotation);
        }

        public override void DisableState() {
            objectBeingExamined.ObjectMesh.position = originalPosition;
            objectBeingExamined.ObjectMesh.rotation = originalRotation;

            controls.Examining.Disable();
            ExamineUI.SetActive(false);
        }

        public void ExitState () {
            PlayerObject.SetState(PreviousState);
        }
    }
}