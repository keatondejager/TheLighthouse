using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Environment
{
    public class Elevator : MonoBehaviour {
        [SerializeField] protected GameObject ButtonPrompt;
        [SerializeField] protected Vector3 movePosition;
        [SerializeField] protected Transform cam;

        [SerializeField] protected Animator animControl;
        [SerializeField] private int _currentFloor;
        [SerializeField] protected int NextFloorIndex;
        [SerializeField] protected float transitionDuration;
        public int currentFloor {
            get => _currentFloor;
            set {
                _currentFloor = value;
                animControl.SetInteger("FloorIndex", _currentFloor);
            }
        }

        private bool hasFunction = false;

        private void Start() {
            currentFloor = 0;
        }

        private void OnTriggerEnter(Collider other) {
            var manager = other.GetComponent<Player.PlayerManager>();
            if (manager is Player.PlayerManager) {
                ButtonPrompt.SetActive(true);

                manager.OnInteractEnter += Interact;
                hasFunction = true;
            }
        }

        private void OnTriggerExit(Collider other) {
            var manager = other.GetComponent<Player.PlayerManager>();
            if (manager is Player.PlayerManager) {
                ButtonPrompt.SetActive(false);
                if (hasFunction) {
                    manager.OnInteractEnter -= Interact;
                    hasFunction = false;
                }
            }
        }

        private void Interact () {
            if (Player.PlayerReference.instance.puzzleOneComplete) {
                Player.PlayerReference.instance.manager.gameObject.transform.position = movePosition;
                currentFloor = 1;
                Invoke("NarrativeTrigger", transitionDuration);
            } 
        }

        public void NarrativeTrigger () {
            NarrativeController.instance.TriggerNarrative(NextFloorIndex);
        }
    }
}

