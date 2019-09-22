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

        public GameObject examineUI;
        public GameObject menuObject;
        //Matt added
        public GameObject searchUI;

        public Transform examineObject;
        public Transform ExamineRefPoint;
        //Matt Added
        public SearchableObject searchObject;

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

