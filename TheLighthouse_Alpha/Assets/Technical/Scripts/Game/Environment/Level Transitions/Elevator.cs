using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Environment
{
    public class Elevator : MonoBehaviour {
        [SerializeField] protected GameObject ButtonPrompt;
        [SerializeField] protected int CannotOpenIndex;
        [SerializeField] protected Vector3 movePosition;
        [SerializeField] protected Transform cam;
 
        private bool hasFunction = false;

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
                cam.position = new Vector3 (cam.position.x, 4.2f, cam.position.z);
            } else {
                NarrativeController.instance.TriggerNarrative(CannotOpenIndex);
            }
        }
    }
}

