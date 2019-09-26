
using UnityEngine;
using System.Collections.Generic;
using Environment;
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
            public SearchableObjectData objectInventory;

            public List<UI_Item> objectsInGame;

            public List<Item> PlayerInventory;

       

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

