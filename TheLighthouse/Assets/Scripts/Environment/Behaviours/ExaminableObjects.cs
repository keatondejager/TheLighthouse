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

        [Header("Object To Be Examined")]
            [SerializeField] protected string _objName = "Narrative Object";
            [SerializeField] protected string _objDescription = "This object was a part of my narrative.";
            [SerializeField] protected PlayerManager.PlayerManager.NarrativeType _objType; 

            [SerializeField] protected PlayerManager.PlayerManager.InteractableObject _myObj;

        private void Start() {
            _myObj = new PlayerManager.PlayerManager.InteractableObject();

            _myObj.name = _objName;
            _myObj.description = _objDescription;
            _myObj.type = _objType;

        }

        public void Interact () {
            if (!_promptState) {
                return;
            }

            // Tell the player to switch states
            PlayerManager.PlayerManager.instance.SetExamine(_myObj);

            // Tell the player what they are examining

            // Give the object to the player
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
