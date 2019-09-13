using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{   
    [RequireComponent(typeof(Rigidbody), typeof(Animator))]
    public class PlayerManager : MonoBehaviour {

        #region Variables
            [Header("State Machine Control")]
                [SerializeField] protected States state;

            [Space]
                [SerializeField] protected Movement _moveState;
                [SerializeField] protected Examine _examineState;
                [SerializeField] protected Interact _interactState;
                [SerializeField] protected Inventory  _inventoryState;
                [SerializeField] protected Menus _menuState;
            
            [Header("Input Control")]
                private PlayerInputActions controls;
        
        #endregion

        private void Awake() {
            controls = new PlayerInputActions();
        }

        // Start is called before the first frame update
        private void Start() {

            _moveState.Initialize(controls);
            _examineState.Initialize(controls);
            _interactState.Initialize(controls);
            _inventoryState.Initialize(controls);
            _menuState.Initialize(controls);

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

    }
}

