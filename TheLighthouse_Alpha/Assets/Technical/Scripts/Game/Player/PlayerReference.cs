
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
            public bool puzzleSteamComplete = false;
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


        int vibrationIterations; float vibrateDuration; float lowFreqIntensity; float highFreqIntensity; float vibrateInterval;
        bool controllerShaking;
        public void ShakeController (string path, int count = 2, float length = 0.2f, float interval = 0.2f, float low = 0.3f, float high = 0.4f) {
            if (controllerShaking) {
                return;
            }

            if (!path.Contains("DualShock4")) {
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
            controllerShaking = false;
        }
    }

    
}

