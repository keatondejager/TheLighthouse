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
        
        public override void Initialize (PlayerInputActions _controls) {
            controls = _controls;

            PlayerObject = PlayerReference.instance.manager;
            controls.PuzzleControls.Close.performed += ctx => ExitState();
            controls.PuzzleControls.PrimaryButton.performed += ctx => StartInput();
            
        }

        public override void Step() {

        }   
        
        private void StartInput () {
            // if (checkingInput) {
            //     return;
            // }

            // checkingInput = true; 

            if (puzzle.puzzleState == 7) {
                return;
            }

            InputMethods[puzzle.puzzleState].Invoke();
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

