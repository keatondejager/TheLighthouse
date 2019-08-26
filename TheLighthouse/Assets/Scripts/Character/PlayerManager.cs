using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using DG.Tweening;
using UnityEngine;


namespace PlayerManager
{   
    [RequireComponent(typeof(Rigidbody), typeof(Animator), typeof(CapsuleCollider))]
    public partial class PlayerManager : MonoBehaviour {

        public enum NarrativeType {
            Definitive = 0,
            Optional = 1,
            Hidden = 2,
            Searchable = 3,
            Climbable = 4,
            Fixable = 5,
            Cleanable = 6
        }


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

                public enum PlayerState {
                    Movement, Examining, Interacting, Inventory, Menu
                }

                [SerializeField] private PlayerState _previousState;
                [SerializeField] private PlayerState _currentState = PlayerState.Movement;

                public PlayerState CurrentState {
                    get => _currentState;
                    set {
                        _previousState = _currentState;
                        _currentState = value;
                    }
                }

                [SerializeField] protected List<Item> _inventory;

            #region Methods
                private void Update() {
                    Move();
                    Examine();
                    Search();
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
                    
                    //* Movement */
                    _controls.Movement.Move.performed += ctx => direction = ctx.ReadValue<Vector2>();
                    _controls.Movement.Move.canceled += ctx => direction = Vector2.zero;

                    _controls.Movement.Jump.performed += ctx => Jump();

                    _controls.Movement.Examine.performed += ctx => ExamineEvent();
                    _controls.Movement.Search.performed += ctx => InteractEvent();

                    //* EXAMINING */
                    _controls.Examine.Close.performed += ctx => ExitExamine();

                    _controls.Examine.Zoom.performed += ctx => _examineZoom = ctx.ReadValue<float>();
                    _controls.Examine.Zoom.canceled += ctx => _examineZoom = 0f;

                    _controls.Examine.Rotate.performed += ctx => _examineRotation = ctx.ReadValue<Vector2>();
                    _controls.Examine.Rotate.canceled += ctx => _examineRotation = Vector2.zero;

                    //* INTERACTIONS */
                    _controls.Search.Close.performed += ctx => ExitSearch();
                }

                private void Start () {
                    _rigidbody = GetComponent<Rigidbody>();
                    _animator = GetComponent<Animator>();
                }

                private void OnEnable() {
                    _controls.Movement.Enable();
                    _previousState = PlayerState.Movement;
                }

                private void OnDisable() {
                    _controls.Movement.Disable();
                    _controls.Examine.Disable();
                    _controls.Search.Disable();
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
