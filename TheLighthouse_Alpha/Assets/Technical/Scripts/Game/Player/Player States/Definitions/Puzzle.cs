using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
    public class Puzzle : States
    {

        [Header("Visuals")]
            [SerializeField] protected DB_Puzzle puzzleManager;
        public override void Initialize (PlayerInputActions _controls) {
            controls = _controls;

            PlayerObject = PlayerReference.instance.manager;
            controls.PuzzleControls.Close.performed += ctx => ExitState();
        }

        public override void Step() {

        }

        public override void EnableState() {
            controls.PuzzleControls.Enable();
            puzzleManager.gameObject.SetActive(true);
        }

        public override void DisableState() {
            controls.PuzzleControls.Disable();
            puzzleManager.gameObject.SetActive(false);
        }
    }
}

