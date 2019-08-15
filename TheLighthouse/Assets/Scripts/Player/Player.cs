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
        protected Rigidbody _rigidbody;
        public new Rigidbody rigidbody => _rigidbody;

        protected Animator _animator;
        public Animator animator => _animator;

        [SerializeField] protected float _speed;
        public float speed => _speed;

        private Vector2 _direction;
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
            return;
        }

        Move();
    }

    protected void Jump () {

    }

    protected void Move () {
        Vector2 dir = _direction.normalized;
        rigidbody.velocity = dir * speed;
        
        animator.SetFloat("walkSpeed", _direction.x);
        animator.SetBool("isWalking", _direction.x != 0);
    }

    protected void InitiateSearch() {
        animator.SetBool("canMove", false);
        animator.SetBool("isSearching", true);
        _canMove = false;
        print("Searching");
    }

    protected void InitiateExamine () {
        animator.SetBool("canMove", false);
        animator.SetBool("isExamining", true);
        _canMove = false;
        print("Examining");
    }

    protected void CloseSearch() {
        animator.SetBool("canMove", true);
        animator.SetBool("isSearching", false);
        _canMove = true;
        print("Not Searching");
    }

    protected void CloseExamine () {
        animator.SetBool("canMove", true);
        animator.SetBool("isExamining", false);
        _canMove = true;
        print("Not Examining");
    }

}
