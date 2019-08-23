using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Collisions
namespace PlayerManager
{
    public partial class PlayerManager {
        #region Collisions
            [Header("Collision Control Variables")]
                [SerializeField] protected Vector3 groundOffset;
                [SerializeField] protected float groundCheckRadius;
                [SerializeField] protected LayerMask groundLayer;

            #region Methods
                private void GroundCheck () {
                    if (!canMove) {
                        return;
                    }
                    isGrounded = Physics.Raycast(transform.position + groundOffset, Vector3.down, groundCheckRadius, groundLayer);
                }

                private void WallCheck () {
                    if (!canMove) {
                        return;
                    }
                    // Raycast forward to check if the player is walking into a wall.
                }

                private void OnDrawGizmos() {
                    Gizmos.DrawLine(transform.position + groundOffset, transform.position + groundOffset + Vector3.down * groundCheckRadius);
                }
            #endregion

        #endregion
    }

}
