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
            
            [Header("Input Control")]
                private PlayerInputActions controls;
        
        #endregion

        private void Awake() {
            controls = new PlayerInputActions();

            controls.Movement.Interact.performed += ctx => SetState(_interactState);
            controls.Movement.Examine.performed += ctx => SetState(_examineState);
            controls.Movement.Inventory.performed += ctx => SetState(_moveState);
            controls.Movement.Menu.performed += ctx => SetState(_moveState);

            controls.Inventory.Exit.performed += ctx => SetState(_moveState);
            controls.Menus.Exit.performed += ctx => SetState(_moveState);
            controls.Interact.Exit.performed += ctx => SetState(_moveState);
            controls.Examining.Exit.performed += ctx => SetState(_moveState);
        }

        // Start is called before the first frame update
        private void Start() {

            _moveState.Initialize(controls);
            _examineState.Initialize(controls);
            _interactState.Initialize(controls);

            if (!state) {
                SetState(_moveState);
            }
        }

        // Update is called once per frame
        private void Update() {
            state.Step();
        }

        private void SetState (States newState) {
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

