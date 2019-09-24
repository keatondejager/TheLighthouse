
using UnityEngine;
using TMPro;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerReference : MonoBehaviour
    {
        public static PlayerReference instance;

        public new Rigidbody rigidbody;
        public Animator animator;
        public PlayerManager manager;

        [Header("Examining")]
            public GameObject examineUI;
            public TMP_Text examineObjectName;
            public ExamineObjectData examineObject;
            public Transform ExamineRefPoint;
        [Header("Menus")]
            public GameObject menuObject;
        [Header("Interactions")]
            public GameObject searchingUI;

       

        private void Awake() {
            if (instance == null) {
                instance = this;
            } else if (instance != this) {
                Destroy(this.gameObject);
            }
        }

        private void Start() {
            rigidbody = GetComponent<Rigidbody>();
            manager = GetComponent<PlayerManager>();
        }
    }
}

