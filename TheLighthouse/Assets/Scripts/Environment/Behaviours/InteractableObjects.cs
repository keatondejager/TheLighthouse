using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Environment
{
    [RequireComponent(typeof(BoxCollider))]
    public class InteractableObjects : MonoBehaviour, IInteractable
    {
        [Header("Interaction Controls")]
            [SerializeField] protected GameObject _buttonPrompt ;
            [Range(0.1f, 0.5f)] [SerializeField] protected float _disableDelay = 0.2f;
            [SerializeField] protected bool _promptState = false;

        [Header("Object To Be Interated")]
            [SerializeField] protected string _objName = "Narrative Object";
            [SerializeField] protected string _objDescription = "This object was a part of my narrative.";
            [SerializeField] protected PlayerManager.PlayerManager.NarrativeType _objType; 
            [SerializeField] protected PlayerManager.PlayerManager.InteractableObject _myObj;

        public void Interact () {
            if(!_promptState) {
                return;
            }
            
            PlayerManager.PlayerManager.instance.StartSearch();
        }

        private void OnTriggerEnter(Collider other) {
            if (other.CompareTag("Player")){

                if (!_promptState) {
                    PlayerManager.PlayerManager.OnInteract += Interact;
                }

                _promptState = true;
                _buttonPrompt.SetActive(true);
            }
        }

        private void OnTriggerExit(Collider other) {
            if (other.CompareTag("Player")){


                _promptState = false;
                Invoke("DisableDisplay", _disableDelay);
            }
        }

        private void DisableDisplay () {
            if (_promptState) {
                return;
            }
            PlayerManager.PlayerManager.OnInteract -= Interact;
            _buttonPrompt.SetActive(false);
        }

        private void OnDisable() {
            if (!_promptState) {
                return;
            }
            PlayerManager.PlayerManager.OnInteract -= Interact;
        }

    }

}
