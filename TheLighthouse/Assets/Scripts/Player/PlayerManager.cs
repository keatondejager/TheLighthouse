using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Animator))]

public abstract class PlayerManager : MonoBehaviour
{
    [Header("Movement")]
        protected Rigidbody _rigidbody;
            public Rigidbody rb => _rigidbody;

        [Range(0, 10)][SerializeField] protected float _speed;
        [Range(0, 20)][SerializeField] protected float _jumpForce;

        public float Speed => _speed;
        public float JumpForce => _jumpForce;

    
    [Header("Animation")]
        protected Animator _animControl;
            public Animator PlayerAnimation => _animControl;


    protected void Initialize () {
        _rigidbody = GetComponent<Rigidbody>();
        _animControl = GetComponent<Animator>();
        Debug.Log("Initialized Player");
    } 

    public virtual void Move (Vector3 direction) {
        rb.velocity = direction.normalized * Speed;
    }
    
}
