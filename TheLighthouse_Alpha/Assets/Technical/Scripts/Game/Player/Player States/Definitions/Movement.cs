using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Movement State", menuName = "Player State/Movement")]
    public class Movement : States {

        [Header("State Reference")]
            [SerializeField] protected Examine _examineState;
            [SerializeField] protected Interact _interactState;
            [SerializeField] protected CombinationPuzzle _ComboPuzzleState;             

        [Header("Component Reference")]
            [SerializeField] protected Rigidbody _rigidbody;
            [SerializeField] protected Animator _animator;

        [Header("Movement Control")]
            [SerializeField] private Vector2 direction;
            [SerializeField] private Vector2 lookDirection;
            private Vector3 motion;
            private Vector3 rotation;
            [Range(1, 10)] [SerializeField] protected float moveSpeed = 1f;
            [Range(1, 10)] [SerializeField] protected float acceleration = 1f;
            [Range(1, 10)] [SerializeField] protected float decceleration = 2f;

            [Range(0, 1)] [SerializeField] protected float rotationsPerSecond = 0.2f;
            [Range(5, 15)] [SerializeField] protected float lookRotationSpeed = 5f;

            [Range(0, 90)] [SerializeField] protected float maxCollisionAngle = 25f;

            [SerializeField] protected bool grounded;
            [SerializeField] protected bool obstructed;

        [Header("Collisions")]
            [SerializeField] protected float groundCheckLength;
            [SerializeField] protected float forwardCheckOffset;
            [SerializeField] protected float forwardCheckRadius; 
            [SerializeField] protected LayerMask collisionLayer;

        [Header("Animations")]
            [SerializeField] private bool _isWalking;
            protected bool isWalking {
                get => _isWalking;
                set {
                    _isWalking = value;
                    if (_animator)
                        _animator.SetBool("isWalking", _isWalking);
                }
            }
        

        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;

            PlayerObject = PlayerReference.instance.manager;
            _rigidbody = PlayerReference.instance.rigidbody;
            _animator = PlayerReference.instance.animator;

            controls.Movement.Examine.started += ctx => ExamineClick();
            controls.Movement.Interact.started += ctx => InteractClick();
            controls.Movement.Inventory.started += ctx => InventoryClick();
            controls.Movement.Menu.started += ctx => MenuClick();

            controls.Movement.Walk.performed += ctx => direction = ctx.ReadValue<Vector2>();
            controls.Movement.Walk.canceled += ctx => direction = Vector2.zero;

            controls.Movement.Look.performed += ctx => lookDirection = ctx.ReadValue<Vector2>();
            controls.Movement.Look.canceled += ctx => lookDirection = Vector2.zero;
        }

        public override void Step() {
            _rigidbody.angularVelocity = Vector3.zero;

            grounded = GroundCheck();

            if (!grounded) { 
                return;
            }

            obstructed = ForwardCheck();

            motion = Vector3.forward * direction.y + Vector3.right * direction.x;
            rotation = Vector3.right * lookDirection.x + Vector3.forward * lookDirection.y;
            
            if (obstructed) {
                if (Vector3.Angle(PlayerObject.transform.forward, motion) < maxCollisionAngle && motion.sqrMagnitude > 0) {
                    isWalking = false;
                    return;
                }
            }

            motion.Normalize();
            if (motion.sqrMagnitude > 0) {
                PlayerObject.transform.rotation = Quaternion.Lerp(  PlayerObject.transform.rotation, 
                                                                 Quaternion.LookRotation(motion), 
                                                                 rotationsPerSecond * 180 * Time.deltaTime);
                isWalking = true;
                AudioManager.instance.StartWalking();
                
            } else { 
                
                if (rotation.sqrMagnitude > 0) {
                    PlayerObject.transform.rotation = Quaternion.Lerp(  PlayerObject.transform.rotation, 
                                                                    Quaternion.LookRotation(rotation), 
                                                                    rotationsPerSecond * 180 * Time.deltaTime);
                }

                isWalking = false;
                AudioManager.instance.StopWalking();
                    
            }
            motion *= moveSpeed;

            motion.y = _rigidbody.velocity.y;

            _rigidbody.velocity = motion;

            
        }

        private bool GroundCheck() {
            return Physics.Raycast(PlayerObject.transform.position, Vector3.down, groundCheckLength, collisionLayer);
        }

        private bool ForwardCheck() {
            bool result = Physics.CheckSphere(PlayerObject.transform.position + PlayerObject.transform.forward * forwardCheckOffset, forwardCheckRadius, collisionLayer);
            result = result || Physics.CheckSphere(PlayerObject.transform.position - (Vector3.up * -1f) + (PlayerObject.transform.forward * forwardCheckOffset), forwardCheckRadius, collisionLayer);
            return result;
        }

        #region StateChange
        public override void EnableState() {
            controls.Movement.Enable();
        }

        public override void DisableState() {
            controls.Movement.Disable();
            direction = Vector2.zero;
            isWalking = false;
        }

        private void ExamineClick() {
            PlayerObject.ExamineButtonDown();
        }

        private void InteractClick () {
            PlayerObject.InteractButtonDown();
        }

        private void InventoryClick () {
            PlayerObject.SetState(_ComboPuzzleState);
        }

        private void MenuClick () {
            PlayerObject.SetState(_menuState);
        }
        #endregion
    }
}