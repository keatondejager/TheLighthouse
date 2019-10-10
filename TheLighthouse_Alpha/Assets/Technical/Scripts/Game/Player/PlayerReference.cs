
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

        private bool _hasLantern = false;
        public bool hasLantern {
            get => _hasLantern;
            set {
                _hasLantern = value;
                animator.SetBool("hasLantern", _hasLantern);
            }
        }
        
        [Header("Examining")]
            public GameObject examineUI;
            public TMP_Text examineObjectName;
            public ExamineObjectData examineObject;
            public Transform ExamineRefPoint;
        [Header("Menus")]
            public GameObject menuObject;
            public GameObject MainMenuObj;
            public GameObject OptionsMenuObj;
        [Header("Interactions")]
            public GameObject searchingUI;
            public SearchableObjectData objectInventory;

            public DB_Puzzle dB_Puzzle;

            public DistributionBoard distributionPuzzle;
            public DoorLock combinationLock;

            public TMP_Text interactableTitle;

            public List<UI_Item> objectsInGame;

            public List<Item> PlayerInventory;

        [Header("Puzzle Cheats")]
            public GameObject CheatButtons;

        [Header("Puzzle Reference")]
            public TMP_Text instructions;

            public bool puzzleOneComplete = false;
            public bool puzzleTwoComplete = false;

            public bool canDoTransition = false;
       

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

