using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

namespace Environment {
    [RequireComponent(typeof(BoxCollider))]
    public class Examinable : MonoBehaviour
    {
        [Header("Triggers and Collisions")]
            [SerializeField] protected BoxCollider triggerCollider;
            [SerializeField] protected BoxCollider objectCollider;
            [Range(1, 5)] [SerializeField] protected float TriggerScale;

        [Header("Reference")]
            private PlayerManager player; 
            public GameObject Prompt;
            public ExamineObjectData TargetObject;
            public GameObject ExamineHighlightEffect;

            //private bool hasBeenExamined = false;

        [Header("Narrative and Events")]
            public bool isNarrativeTrigger;
            public bool triggerOnExit;
            public int exitIndex;
            public delegate void NarrativeTrigger();
            public event NarrativeTrigger OnNarrativeTrigger;

            private bool hasInteracted = false;

        private void Start() {
            player = PlayerReference.instance.manager;
        }

        protected virtual void OnTriggerEnter (Collider other) {
            if (other.CompareTag("Player")) {
                if (!player) { 
                    player = PlayerReference.instance.manager; 
                }
                PlayerReference.instance.examineObject = TargetObject;
                player.OnExamineEnter += Examine;
                
                Prompt.SetActive(true);
            }
        }

        protected virtual void OnTriggerExit(Collider other) {
            if (other.CompareTag("Player")) {
                if (!player) { 
                    player = PlayerReference.instance.manager; 
                }
                PlayerReference.instance.examineObject = null;
                player.OnExamineEnter -= Examine;
                
                if (triggerOnExit && hasInteracted) {
                    NarrativeController.instance.TriggerNarrative(exitIndex);
                }

                Prompt.SetActive(false);
            }
        }

        public virtual void Examine() {
            //hasBeenExamined = true;
            hasInteracted = true;
            if (ExamineHighlightEffect) {
                ExamineHighlightEffect.SetActive(false);
            }
            PlayerReference.instance.examineObject = TargetObject;
    
            if (isNarrativeTrigger && OnNarrativeTrigger != null) {
                OnNarrativeTrigger();
            }
        }
    }
}
