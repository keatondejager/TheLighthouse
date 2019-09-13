using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody), typeof(Animator))]
    public class PlayerReference : MonoBehaviour
    {
        public static PlayerReference instance;

        public new Rigidbody rigidbody;
        public Animator animator;
        public PlayerManager manager;

        private void Awake() {
            if (instance == null) {
                instance = this;
            } else if (instance != this) {
                Destroy(this.gameObject);
            }
        }

        private void Start() {
            rigidbody = GetComponent<Rigidbody>();
            animator = GetComponent<Animator>();
            manager = GetComponent<PlayerManager>();
        }
    }
}

