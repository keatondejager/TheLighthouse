using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionChecks : MonoBehaviour
{

    [Header("Ground Check Values")]
        [SerializeField] protected Vector3 _offset;
        [SerializeField] protected float _radius;
        [SerializeField] protected LayerMask _collisionLayer;

        [SerializeField] private bool grounded;

    // Update is called once per frame
    void Update()
    {
        if (!Player.instance.Grounded) {
            grounded = Physics.OverlapSphere(transform.position - _offset, _radius, _collisionLayer).Length > 0;
            if (grounded)
                Player.instance.LandOnGround();
        }
    }

    private void OnDrawGizmos() {
        Gizmos.DrawWireSphere(transform.position - _offset, _radius);
    }
}
