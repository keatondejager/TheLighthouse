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
            [SerializeField] protected Vector3 TriggerSize;
            [SerializeField] protected bool useOriginalTriggerSize;
            
         [Header("Narrative and Events")]
            public bool isNarrativeTrigger;
            public delegate void NarrativeTrigger();
            public event NarrativeTrigger OnNarrativeTrigger;

        [Header("General Reference")]
            public GameObject Prompt;
            private PlayerManager player; 

            private bool hasFunction = false;

        protected virtual void Start() {
            triggerRange.isTrigger = true;
            player = PlayerReference.instance.manager;

            if (useOriginalTriggerSize) {
                return;
            }

            if (TriggerSize.sqrMagnitude < objectCollider.size.sqrMagnitude) {
                TriggerSize = objectCollider.size * 1.01f;
            }
            triggerRange.size = TriggerSize;
            
        }

        public virtual void OnTriggerEnter (Collider other) {
            if (other.CompareTag("Player")) {
                if (!player) { 
                    player = PlayerReference.instance.manager; 
                }
                player.OnInteractEnter += Interact;
                hasFunction = true;
                Prompt.SetActive(true);
            }
        }

        public virtual void OnTriggerExit(Collider other) {
            if (other.CompareTag("Player")) {
                if (!player) { 
                    player = PlayerReference.instance.manager; 
                }
                if (hasFunction) {
                    player.OnInteractEnter -= Interact;
                    hasFunction = false;
                }
                Prompt.SetActive(false);
            }
        }

        public virtual void Interact() {
            if (isNarrativeTrigger && OnNarrativeTrigger != null) {
                OnNarrativeTrigger();
            }
        }
    }

}