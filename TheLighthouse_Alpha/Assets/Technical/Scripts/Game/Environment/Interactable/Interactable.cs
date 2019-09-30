using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Environment {

    [RequireComponent(typeof(BoxCollider))]
    public abstract class Interactable : MonoBehaviour {
        
        [Header("Control Reference")]
            [SerializeField] protected BoxCollider triggerRange;
            [SerializeField] protected BoxCollider objectCollider;
            [Range(1f, 5f)] [SerializeField] protected float TriggerScale = 2f;
            [SerializeField] protected SearchableObjectData ObjectInventory;


         [Header("Narrative and Events")]
            public bool isNarrativeTrigger;
            public delegate void NarrativeTrigger();
            public event NarrativeTrigger OnNarrativeTrigger;

        [Header("General Reference")]
            public GameObject Prompt;
            private PlayerManager player; 

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
                PlayerReference.instance.objectInventory = ObjectInventory;
                player.OnInteractEnter += Interact;
                Prompt.SetActive(true);
            }
        }

        protected virtual void OnTriggerExit(Collider other) {
            if (other.CompareTag("Player")) {
                if (!player) { 
                    player = PlayerReference.instance.manager; 
                }
                PlayerReference.instance.objectInventory = null;
                player.OnInteractEnter -= Interact;
                Prompt.SetActive(false);
            }
        }

        public virtual void Interact() {
            PlayerReference.instance.objectInventory = ObjectInventory;
            player.OnInteractEnter -= Interact;
            if (isNarrativeTrigger && OnNarrativeTrigger != null) {
                OnNarrativeTrigger();
            }
        }
    }

}