using UnityEngine;

namespace Player {

    [CreateAssetMenu(fileName = "Combination Puzzle State", menuName = "Player State/Combo Puzzle")]
    public class CombinationPuzzle : States {
        
        private CombinationLock puzzle;
        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
        }

        public override void Step() {

        }

        public override void EnableState() {
            if (PlayerReference.instance.combinationLock == null) {
                ExitState();
            }
            puzzle = PlayerReference.instance.combinationLock;
            puzzle.OpenPuzzle();
        }

        public override void DisableState() {
            if (!puzzle) {
                return;
            }
            puzzle.ClosePuzzle();
        }

    }

}

