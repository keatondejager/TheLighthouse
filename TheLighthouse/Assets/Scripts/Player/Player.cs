using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody), typeof(Animator))]
public class Player : MonoBehaviour
{

    [Header("Static Reference")]
        public static Player instance;
        public static PlayerControls controls;

    [Header("General Reference")]
        [SerializeField] protected Rigidbody _rigidbody;
        public new Rigidbody rigidbody => _rigidbody;

        [SerializeField] protected Animator _animator;
        public Animator animator => _animator;

        [SerializeField] protected float _speed;
        public float speed => _speed;

        [SerializeField] protected float _turnSpeed;
        public float turnSpeed => _turnSpeed;

        private bool isGrounded;
        private Vector2 _direction;
        private Vector2 _rotation;
        private bool _canMove;
    

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this.gameObject);
            return;
        }

        controls = new PlayerControls();

        //! MOVEMENT CONTROLS SETUP
        controls.Movement.Jump.performed += ctx => Jump();

        controls.Movement.Move.performed += ctx => _direction = ctx.ReadValue<Vector2>();
        controls.Movement.Move.canceled += ctx => _direction = Vector2.zero;

        controls.Movement.Rotate.performed += ctx => _rotation = ctx.ReadValue<Vector2>();
        controls.Movement.Rotate.canceled += ctx => _rotation = Vector2.zero;

        controls.Movement.Search.performed += ctx => InitiateSearch();
        controls.Movement.Examine.performed += ctx => InitiateExamine();

        //! EXAMINE CONTROLS SETUP
        controls.Search.Close.performed += ctx => CloseSearch();

        //! SEARCH CONTROLS SETUP
        controls.Examine.Close.performed += ctx => CloseExamine();
    }

    private void Start() {
        if (!_rigidbody) {
            _rigidbody = GetComponent<Rigidbody>();
        }

        if (!_animator) {
            _animator = GetComponent<Animator>();
        }

        animator.SetBool("canMove", true);
        _canMove = true;
    }

    private void Update() {
        if (!_canMove) {
            rigidbody.velocity = new Vector3 (0, rigidbody.velocity.y, 0);
            return;
        } 

        Move();
    }

    protected void Jump () {
        animator.SetTrigger("Jump");
    }

    protected void Move () {
        Vector3 temp = _direction.normalized;
        Vector3 dir = Vector3.right * temp.x + Vector3.forward * temp.y;
    
        rigidbody.velocity = dir * speed;
        if (_direction.sqrMagnitude != 0)
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), turnSpeed * Time.deltaTime);

        // animator.SetFloat("walkSpeed_y", _direction.y);
        // animator.SetFloat("walkSpeed_x", _direction.x);
        animator.SetBool("isWalking", _direction.sqrMagnitude != 0);
    }

    protected void InitiateSearch() {
        animator.SetBool("canMove", false);
        animator.SetBool("isSearching", true);
        _canMove = false;
    }

    protected void InitiateExamine () {
        animator.SetBool("canMove", false);
        animator.SetBool("isExamining", true);
        _canMove = false;
    }

    protected void CloseSearch() {
        animator.SetBool("canMove", true);
        animator.SetBool("isSearching", false);
        _canMove = true;
    }

    protected void CloseExamine () {
        animator.SetBool("canMove", true);
        animator.SetBool("isExamining", false);
        _canMove = true;
    }

}
