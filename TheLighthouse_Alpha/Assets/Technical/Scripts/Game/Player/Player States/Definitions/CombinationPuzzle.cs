using UnityEngine;

namespace Player {

    [CreateAssetMenu(fileName = "Combination Puzzle State", menuName = "Player State/Combo Puzzle")]
    public class CombinationPuzzle : States {
        
        protected CombinationLock puzzle;
        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;

            controls.PuzzleControls.Close.performed += ctx => ExitState();
        }

        public override void Step() {

        }

        public override void EnableState() {
            if (PlayerReference.instance.combinationLock == null) {
                ExitState();
            }
            //puzzle = PlayerReference.instance.combinationLock;
            puzzle.callbackManager = this;
            puzzle.OpenPuzzle();
            controls.PuzzleControls.Enable();
        }

        public override void DisableState() {
            if (!puzzle) {
                return;
            }
            puzzle.ClosePuzzle();
            controls.PuzzleControls.Disable();
        }

    }

}

