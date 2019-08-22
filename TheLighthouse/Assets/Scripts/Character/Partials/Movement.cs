using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Movement
namespace PlayerManager
{
    public partial class PlayerManager {
        #region Movement
            [Header("Movement Control")]
                [Range(1, 5)] [SerializeField] protected float _speed = 1;
                [Range(10, 40)] [SerializeField] protected float _jumpForce = 1;
                [Range(0.1f, 1)] [SerializeField] protected float _turnSpeed = 0.5f;
                [Range(0.5f, 3.5f)] [SerializeField] protected float _jumpDelay = 0.5f;

                [Header("Reference")]
                [SerializeField] private Vector2 direction;
                [SerializeField] private bool canJump = true;
            
            #region Methods
                protected void Move () {
                    if (!canMove) {
                        return;
                    }
                    Vector3 Offset = Vector3.forward * direction.y + Vector3.right * direction.x;

                    if (Offset.sqrMagnitude > 0) {
                        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(Offset), _turnSpeed * 20f * Time.deltaTime);
                        isWalking = isGrounded;
                    } else {
                        isWalking = false;
                    }

                    Offset = Offset.normalized * _speed;
                    Offset.y = _rigidbody.velocity.y;
                    _rigidbody.velocity = Offset;
                }

                protected void Jump () {
                    if (!isGrounded || !canMove || !canJump) {
                        return;
                    }
                    _rigidbody.AddForce(transform.up * _jumpForce, ForceMode.Impulse);
                    isGrounded = false;
                    canJump = false;
                    Invoke("ResetJump", _jumpDelay);
                }

                private void ResetJump () {
                    canJump = true;
                }
            #endregion

        #endregion
    }
}
