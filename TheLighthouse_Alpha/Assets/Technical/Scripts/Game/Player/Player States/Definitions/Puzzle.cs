
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(menuName = "Player State/Puzzle", fileName = "DB Puzzle")]
    public class Puzzle : States
    {

        [Header("Puzzle Object")]
            [SerializeField] protected DistributionBoard puzzleObject;

        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
            controls.PuzzleControls.Close.started += ctx => ExitState();

            puzzleObject = PlayerReference.instance.distributionPuzzle;
        }


        public override void EnableState() {
            puzzleObject.OpenPuzzle();
            controls.PuzzleControls.Enable();
        }

        public override void DisableState() {
            controls.PuzzleControls.Enable();
            puzzleObject.ClosePuzzle();
        }
    }
        
}

