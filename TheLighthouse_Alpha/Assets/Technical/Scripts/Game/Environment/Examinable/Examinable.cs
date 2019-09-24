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

        private void Start() {
            triggerCollider.isTrigger = true;
            objectCollider.isTrigger = false;
            triggerCollider.size = objectCollider.size * TriggerScale;

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
                
                Prompt.SetActive(false);
            }
        }

        public virtual void Examine() {
            PlayerReference.instance.examineObject = TargetObject;
        }
    }
}
