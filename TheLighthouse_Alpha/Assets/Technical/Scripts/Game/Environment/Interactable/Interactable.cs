using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Environment {

    [RequireComponent(typeof(BoxCollider))]
    public abstract class Interactable : MonoBehaviour {
        [SerializeField] protected BoxCollider triggerRange;
        [SerializeField] protected BoxCollider objectCollider;
        [Range(1f, 5f)] [SerializeField] protected float TriggerScale = 2f;

        private PlayerManager player; 
        public GameObject Prompt;

        protected virtual void Start() {
            triggerRange.isTrigger = true;
            triggerRange.size = objectCollider.size * TriggerScale;
            objectCollider.isTrigger = false;

            player = PlayerReference.instance.manager;
        }

        protected virtual void OnTriggerEnter (Collider other) {
            if (other.CompareTag("Player")) {
                if (!player) { 
                    player = PlayerReference.instance.manager; 
                }
                player.OnInteractEnter += Interact;
                Prompt.SetActive(true);
            }
        }

        protected virtual void OnTriggerExit(Collider other) {
            if (other.CompareTag("Player")) {
                if (!player) { 
                    player = PlayerReference.instance.manager; 
                }
                player.OnInteractEnter -= Interact;
                Prompt.SetActive(false);
            }
        }

        public virtual void Interact() {
            
        }
    }

}