
using UnityEngine;
using System.Collections.Generic;
using Environment;
using TMPro;

using UnityEngine.InputSystem;
using System.Collections;

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


            public TMP_Text interactableTitle;

            public List<UI_Item> objectsInGame;

            public List<Item>  PlayerInventory;

            public Dictionary<int, int> NarrativeItemCues = new Dictionary<int, int>() {
                {0, 8}, //Screwdriver
                {1, 7}, //Wires
                {2, 9}, // Switch
                {7, 24}  // Wrench                
            };


            public void AddItemToInventory(Item item) {
                PlayerInventory.Add(item);
                if (NarrativeItemCues.ContainsKey(item.itemCode)) {
                    NarrativeController.instance.TriggerNarrative(NarrativeItemCues[item.itemCode]);
                }
                RefreshCheckList();
            }

            public void RefreshCheckList () {
                if (OnInventoryChange != null) {
                    OnInventoryChange();
                }
            }

            public delegate void InventoryChange();
            public event InventoryChange OnInventoryChange;

        [Header("Puzzle Cheats")]
            public GameObject CheatButtons;

        [Header("Puzzle Reference")]
            public DistributionBoard distributionPuzzle;
            public DoorLock combinationLock;
            public Valve_Puzzle valvePuzzle;
            public TMP_Text instructions;

            public bool puzzleOneComplete = false;
            public bool puzzleTwoComplete = false;
            public bool puzzleSteamComplete = false;
            public bool canDoTransition = false;
        
        [Header("Narrative")]
            public bool hasInteractedWithDoor;
       

        private PlayerInputActions controls;
        private void Awake() {
            if (instance == null) {
                instance = this;
            } else if (instance != this) {
                Destroy(this.gameObject);
            }

            controls = new PlayerInputActions();
            controls.CheatCodes.Level1.performed += ctx => puzzleOneComplete = true;
            controls.CheatCodes.Level2.performed += ctx => puzzleTwoComplete = true;

            controls.CheatCodes.Enable();

        }

        private void Start() {
            rigidbody = GetComponent<Rigidbody>();
            manager = GetComponent<PlayerManager>();
        }


        int vibrationIterations; float vibrateDuration; float lowFreqIntensity; float highFreqIntensity; float vibrateInterval;
        bool controllerShaking;
        public void ShakeController (string path, int count = 2, float length = 0.2f, float interval = 0.2f, float low = 0.3f, float high = 0.4f) {
            if (controllerShaking) {
                return;
            }

            if (!path.Contains("DualShock4") && !path.Contains("XInputController") ) {
                return;
            }

            vibrationIterations = count;
            vibrateDuration = length;
            vibrateInterval = interval;
            lowFreqIntensity = low;
            highFreqIntensity = high;

            StartCoroutine(ControllerFeedback());
        }
        
        private IEnumerator ControllerFeedback () {
            controllerShaking = true;
            for (int i = 0; i < vibrationIterations; i++) {
                Gamepad.current.SetMotorSpeeds(lowFreqIntensity, highFreqIntensity);
                yield return new WaitForSeconds(vibrateDuration);
                Gamepad.current.SetMotorSpeeds(0, 0);
                yield return new WaitForSeconds(vibrateInterval);
            }
            Gamepad.current.SetMotorSpeeds(0f, 0f);
            controllerShaking = false;
        }

        public void StopVibrations () {
            if (controllerShaking) {
                StopAllCoroutines();
                Gamepad.current.SetMotorSpeeds(0f, 0f);
                controllerShaking = false;
            }
        }

        private void OnDisable() {
            StopVibrations();

            controls.CheatCodes.Disable();
        }
    }

    
}

