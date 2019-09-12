using UnityEngine;

namespace Player
{
    [CreateAssetMenu(fileName = "Movement State", menuName = "Player State/Movement")]
    public class Movement : States {

            

        [Header("Component Reference")]
            [SerializeField] protected Rigidbody _rigidbody;
            [SerializeField] protected Animator _animator;

            public float moveSpeed = 0;

        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;

            if (!PlayerObject) {
                PlayerObject = FindObjectOfType<PlayerManager>();
            }
            if (!_rigidbody) {
                _rigidbody = PlayerObject.gameObject.GetComponent<Rigidbody>();
            }
            if (!_animator) {
                _animator = PlayerObject.gameObject.GetComponent<Animator>();
            }
        }

        public override void Step() {
            _rigidbody.velocity = Vector3.forward * Input.GetAxis("Vertical") + Vector3.right * Input.GetAxis("Horizontal");
        }

        public override void EnableState() {
            controls.Movement.Enable();
        }

        public override void DisableState() {
            controls.Movement.Disable();
        }
    }
}