using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(menuName = "Player State/Puzzle", fileName = "DB Puzzle")]
    public class Puzzle : States
    {

        private DB_Puzzle puzzle;
        
        public override void Initialize (PlayerInputActions _controls) {
            controls = _controls;

            PlayerObject = PlayerReference.instance.manager;
            controls.PuzzleControls.Close.performed += ctx => ExitState();
        }

        public override void Step() {

        }

        public override void EnableState() {
            controls.PuzzleControls.Enable();
            puzzle = PlayerReference.instance.dB_Puzzle;
        }

        public override void DisableState() {
            controls.PuzzleControls.Disable();
            puzzle.ClosePuzzle();

        }
    }
}

