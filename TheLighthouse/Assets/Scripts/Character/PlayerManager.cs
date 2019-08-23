using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using DG.Tweening;
using UnityEngine;


namespace PlayerManager
{   
    [RequireComponent(typeof(Rigidbody), typeof(Animator), typeof(CapsuleCollider))]
    public partial class PlayerManager : MonoBehaviour {

        #region General 
            [Header("General")] 
        
                [SerializeField] protected bool _canMove;
                public bool canMove { 
                    get => _canMove;
                    set {
                        _canMove = value; 
                        _animator.SetBool("canMove", _canMove);
                    }
                }
                [SerializeField] protected bool _isGrounded; 
                public bool isGrounded {
                    get => _isGrounded;
                    set{
                        _isGrounded = value;
                        _animator.SetBool("isGrounded", _isGrounded);
                    }
                }
                [SerializeField] protected bool _isWalking;
                public bool isWalking {
                    get => _isWalking;
                    set {
                        _isWalking = value;
                        _animator.SetBool("isWalking", _isWalking);
                    }
                }

            #region Methods
                private void Update() {
                    Move();
                }

                private void FixedUpdate() {
                    GroundCheck();
                }

                

            #endregion

        #endregion

        #region Components
            [Header("Component Reference")]
                public static PlayerManager instance;
                [SerializeField] protected Rigidbody _rigidbody;
                [SerializeField] protected Animator _animator;
                private PlayerControls _controls;
            
            #region Methods
                private void Awake () {

                    if (instance == null) {
                        instance = this;
                    } else if (instance != this) {
                        Destroy(this.gameObject);
                    }

                    _controls = new PlayerControls();

                    _controls.Movement.Move.performed += ctx => direction = ctx.ReadValue<Vector2>();
                    _controls.Movement.Move.canceled += ctx => direction = Vector2.zero;

                    _controls.Movement.Jump.performed += ctx => Jump();

                    _controls.Movement.Examine.performed += ctx => ExamineEvent();
                    _controls.Movement.Search.performed += ctx => InteractEvent();

                }

                private void Start () {
                    _rigidbody = GetComponent<Rigidbody>();
                    _animator = GetComponent<Animator>();
                }

                private void OnEnable() {
                    _controls.Movement.Enable();
                }

                private void OnDisable() {
                    _controls.Movement.Disable();
                }
            #endregion

        #endregion 

        #region Events and Delegates

                public delegate void ExamineClick();
                public delegate void InteractClick();

                public static event ExamineClick OnExamine;
                public static event InteractClick OnInteract;

                private void ExamineEvent() {
                    if (OnExamine != null) {
                        OnExamine();
                    }
                }

                private void InteractEvent () {
                    if (OnInteract != null) {
                        OnInteract();
                    }
                }

        #endregion 

    }
}
