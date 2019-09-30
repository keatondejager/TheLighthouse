using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;

namespace Player
{   
    [RequireComponent(typeof(PlayerReference))]
    public class PlayerManager : MonoBehaviour {

        #region Variables
            [Header("State Machine Control")]
                [SerializeField] protected States state;

            [Space]
                [SerializeField] protected Movement _moveState;
                [SerializeField] protected Examine _examineState;
                [SerializeField] protected Interact _interactState;
                [SerializeField] protected CombinationPuzzle  _combinationPuzzleState;
                [SerializeField] protected Menus _menuState;

                [SerializeField] protected Puzzle _puzzleState;
            
            [Header("Input Control")]
                private PlayerInputActions controls;
            [Header("Lantern")]
                [SerializeField] public GameObject lanternObject;

                
        
        #endregion

        private void Awake() {
            controls = new PlayerInputActions();
        }

        // Start is called before the first frame update
        private void Start() {

            _moveState.Initialize(controls);
            _examineState.Initialize(controls);
            _interactState.Initialize(controls);
            _combinationPuzzleState.Initialize(controls);
            _menuState.Initialize(controls);
            _puzzleState.Initialize(controls);

            if (!state) {
                SetState(_moveState);
            }
        }

        // Update is called once per frame
        private void Update() {
            state.Step();
        }

        public void SetState (States newState) {
            States previousState = _moveState;

            if (state) {
                previousState = state;
                state.DisableState();
            }

            state = newState;
            state.PreviousState = previousState;
            state.EnableState();
        }

        public void SetLantern(bool lanternState) {
            lanternObject.SetActive(lanternState);
            PlayerReference.instance.hasLantern = true;
            SetState(_moveState);
        }

        #region Interactions and Examine Events
            public delegate void OnExamine();
            public delegate void OnInteract();
            public event OnInteract OnInteractEnter;
            public event OnExamine OnExamineEnter;

           public void ExamineButtonDown () {
                if (OnExamineEnter == null) {
                    return;
                }   
                OnExamineEnter();

                if (PlayerReference.instance.examineObject) {
                    SetState(_examineState);
                } 
           }

           public void InteractButtonDown () {
               if (OnInteractEnter == null) {
                   return;
               }

               OnInteractEnter();
               if (PlayerReference.instance.objectInventory) {
                    SetState(_interactState);
               } else if (PlayerReference.instance.dB_Puzzle) { 
                   SetState(_puzzleState);
               } else if (PlayerReference.instance.canDoTransition) {
                   Debug.Log("Transition");
               }
           }

        #endregion

    }
}

