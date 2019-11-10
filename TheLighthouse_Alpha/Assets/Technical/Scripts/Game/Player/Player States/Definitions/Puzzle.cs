
using UnityEngine;

namespace Player
{
    [CreateAssetMenu(menuName = "Player State/Puzzle", fileName = "DB Puzzle")]
    public class Puzzle : States
    {

        [Header("Puzzle Object")]
            [SerializeField] protected DistributionBoard dbPuzzleObject;
            [SerializeField] protected DoorLock comboPuzzleObject;
            [SerializeField] protected Valve_Puzzle valvePuzzle;

        [Header("Distance Calculations")]
            private Transform playertransform;
            private Transform puzzletransform;

        public override void Initialize(PlayerInputActions _controls) {
            controls = _controls;
            controls.PuzzleControls.Close.started += ctx => ExitState();

            playertransform = PlayerReference.instance.manager.transform;
        }

        public override void Step() {
            if (Vector3.Distance(playertransform.position, puzzletransform.position) > 13f) {
                DisableState();
            }
        }


        public override void EnableState() {
            if (!PlayerReference.instance.puzzleOneComplete) {
                dbPuzzleObject = PlayerReference.instance.distributionPuzzle;
                puzzletransform = dbPuzzleObject.transform;
                dbPuzzleObject.OpenPuzzle();
            } else if (!PlayerReference.instance.puzzleTwoComplete) {
                if (PlayerReference.instance.puzzleSteamComplete) {
                    comboPuzzleObject = PlayerReference.instance.combinationLock;
                    comboPuzzleObject.OpenPuzzleUI();
                } else {
                    valvePuzzle = PlayerReference.instance.valvePuzzle;
                    if (valvePuzzle) {
                        valvePuzzle.OpenPuzzleUI();
                    }
                }
            }
            controls.PuzzleControls.Enable();
        }

        public override void DisableState() {
            controls.PuzzleControls.Disable();
            if (dbPuzzleObject)
                dbPuzzleObject.ClosePuzzle();
            if (comboPuzzleObject)
                comboPuzzleObject.ClosePuzzleUI();
            if (valvePuzzle) 
                valvePuzzle.ClosePuzzleUI();
        }   
    }
        
}

