using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace PlayerManager
{   
    [RequireComponent(typeof(Rigidbody), typeof(Animator), typeof(CapsuleCollider))]
    public class PlayerManager : MonoBehaviour {

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
                [SerializeField] protected bool _isWalking;

            #region Methods
                private void Update() {
    
                }

                private void FixedUpdate() {
                    
                }

            #endregion

        #endregion

        #region Components
            [Header("Component Reference")]
                [SerializeField] protected Rigidbody _rigidbody;
                [SerializeField] protected Animator _animator;
            
            #region Methods
                private void Awake () {

                }

                private void Start () {
                    _rigidbody = GetComponent<Rigidbody>();
                    _animator = GetComponent<Animator>();
                }
            #endregion

        #endregion  

        #region Movement
            [Header("Movement Control")]
                [Range(1, 10)] [SerializeField] protected float _speed = 1;
                [Range(1, 10)] [SerializeField] protected float _jumpForce = 1;
            
            #region Methods
                protected void Move () {

                }

                protected void Jump () {

                }
            #endregion

        #endregion

        #region Collisions
            [Header("Collision Control Variables")]
                [SerializeField] protected Vector3 groundOffset;
                [SerializeField] protected float groundCheckRadius;

            #region Methods
                private void GroundCheck () {

                }

                private void OnDrawGizmos() {
                    
                }
            #endregion

        #endregion
    }
}
