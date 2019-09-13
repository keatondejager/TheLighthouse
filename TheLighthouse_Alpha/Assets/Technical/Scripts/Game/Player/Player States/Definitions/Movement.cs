using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Movement State", menuName = "Player State/Movement")]
    public class Movement : States {

        [Header("State Reference")]
            [SerializeField] protected Examine _examineState;
            [SerializeField] protected Interact _interactState;
            [SerializeField] protected Inventory _inventoryState;             

        [Header("Component Reference")]
            [SerializeField] protected Rigidbody _rigidbody;
            [SerializeField] protected Animator _animator;

        [Header("Movement Control")]
            [SerializeField] private Vector2 direction;
            [SerializeField] private Vector3 motion;
            [Range(1, 10)] [SerializeField] protected float moveSpeed = 1f;
        

        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;

            PlayerObject = PlayerReference.instance.manager;
            _rigidbody = PlayerReference.instance.rigidbody;
            _animator = PlayerReference.instance.animator;

            controls.Movement.Examine.performed += ctx => ExamineClick();
            controls.Movement.Interact.performed += ctx => InteractClick();
            controls.Movement.Inventory.performed += ctx => InventoryClick();
            controls.Movement.Menu.performed += ctx => MenuClick();

            controls.Movement.Walk.performed += ctx => direction = ctx.ReadValue<Vector2>();
            controls.Movement.Walk.canceled += ctx => direction = Vector2.zero;
        }

        public override void Step() {
            motion = Vector3.forward * direction.y + Vector3.right * direction.x;

            _rigidbody.velocity = motion * moveSpeed;
        }

        public override void EnableState() {
            controls.Movement.Enable();
        }

        public override void DisableState() {
            controls.Movement.Disable();
        }

        private void ExamineClick() {
            PlayerObject.SetState(_examineState);
        }

        private void InteractClick () {
            PlayerObject.SetState(_interactState);
        }

        private void InventoryClick () {
            PlayerObject.SetState(_inventoryState);
        }

        private void MenuClick () {
            PlayerObject.SetState(_menuState);
        }
    }
}