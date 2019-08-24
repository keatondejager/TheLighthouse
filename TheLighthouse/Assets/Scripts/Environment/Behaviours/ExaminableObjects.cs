using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using PlayerManager;


namespace Environment
{
    
    [RequireComponent(typeof(BoxCollider))]
    public class ExaminableObjects : MonoBehaviour, IExaminable
    {
        [Header("Interaction Controls")]
            [SerializeField] protected GameObject _buttonPrompt;
            [Range(0.1f, 0.5f)] [SerializeField] protected float _disableDelay;
            [SerializeField] protected bool _promptState;

        public void Interact () {
            if (!_promptState) {
                return;
            }

            Debug.Log(this.gameObject.name);
        }

        private void OnTriggerEnter(Collider other) {
            if (other.CompareTag("Player")){

                if (!_promptState) {
                    PlayerManager.PlayerManager.OnExamine += Interact;
                }

                _buttonPrompt.SetActive(true);
                _promptState = true;
                
            }
            
        }

        private void OnTriggerExit(Collider other) {
            if (other.CompareTag("Player")) {
                _promptState = false;
                Invoke("DisableObject", _disableDelay);
            }
        }

        private void DisableObject () {
            if (_promptState){
                return;
            }
            PlayerManager.PlayerManager.OnExamine -= Interact;
            _buttonPrompt.SetActive(false);
        }

        private void OnDisable () {
            if (_promptState) {
                PlayerManager.PlayerManager.OnExamine -= Interact;
            }
        }
    }
}
