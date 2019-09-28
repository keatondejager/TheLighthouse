using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(menuName = "Player State/Puzzle", fileName = "DB Puzzle")]
    public class Puzzle : States
    {

        private DB_Puzzle puzzle;

        private bool checkingInput = false;

        private delegate void PuzzleInput();

        private List<PuzzleInput> InputMethods;

        public enum InputTypes {
            AnalogueClockwise = 0, AnalogueAntiClockwise = 1,
            RightTrigger = 2, LeftTrigger = 3,
            SecondaryButton = 4, TertiaryButton = 5,
            LeftAnalogueMove = 5, RightAnalogueMove = 6
        }

        [SerializeField] private Vector2 LeftAnalogueInput;
        [SerializeField] private Vector2 RightAnalogueInput;

        [SerializeField] private bool isRightTriggerDown = false;
        [SerializeField] private bool isLeftTriggerDown = false;

        public override void Initialize (PlayerInputActions _controls) {
            controls = _controls;

            PlayerObject = PlayerReference.instance.manager;
            controls.PuzzleControls.Close.performed += ctx => ExitState();
            controls.PuzzleControls.PrimaryButton.performed += ctx => StartInput();

            controls.PuzzleControls.PrimaryAxis.performed += ctx => LeftAnalogueInput = ctx.ReadValue<Vector2>();
            controls.PuzzleControls.PrimaryAxis.canceled += ctx => LeftAnalogueInput = Vector2.zero;

            controls.PuzzleControls.SecondaryAxis.performed += ctx => RightAnalogueInput = ctx.ReadValue<Vector2>();
            controls.PuzzleControls.SecondaryAxis.canceled += ctx => RightAnalogueInput = Vector2.zero;

            controls.PuzzleControls.SecondaryButton.performed += ctx => Secondary();
            controls.PuzzleControls.TertiaryButton.performed += ctx => Tertiary();

            controls.PuzzleControls.Hold.performed += ctx => isLeftTriggerDown = true;
            controls.PuzzleControls.Hold.canceled += ctx => isLeftTriggerDown = false;

            controls.PuzzleControls.Grab.performed += ctx => isRightTriggerDown = true;
            controls.PuzzleControls.Grab.canceled += ctx => isRightTriggerDown = false;
            
        }

        public override void Step() {

        }   
        
        private void StartInput () {
            if (checkingInput) {
                return;
            }

            if (puzzle.puzzleState == 7) {
                return;
            }

            checkingInput = true; 
            // Determine what input is to be expected

            //Determine what action will play 

            //Set the result if action completed correctly            
        }

        private void Tertiary() {
            Debug.Log("Tertiary");
        }

        private void Secondary() {
            Debug.Log("Secondary");
        }

        public override void EnableState() {
            controls.PuzzleControls.Enable();
            puzzle = PlayerReference.instance.dB_Puzzle;

            puzzle.CheckRequirements();

            InputMethods = new List<PuzzleInput>();
            InputMethods.Add(puzzle.RemoveScrew);       //0
            InputMethods.Add(puzzle.RemoveCover);       //1
            InputMethods.Add(puzzle.RemoveWire);        //2
            InputMethods.Add(puzzle.PlaceNewSwitch);    //3
            InputMethods.Add(puzzle.InsertWire);        //4
            InputMethods.Add(puzzle.PlaceCoverBack);    //5
            InputMethods.Add(puzzle.NewScrew);          //6
            
        }

        public override void DisableState() {
            controls.PuzzleControls.Disable();
            puzzle.ClosePuzzle();
        }
    }
}

