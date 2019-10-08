using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

namespace Environment
{
    public class DB_PuzzleInteract : Interactable
    {
        [SerializeField] protected DistributionBoard puzzleManager;

        public override void OnTriggerEnter(Collider other) {
            base.OnTriggerEnter(other);
            PlayerReference.instance.distributionPuzzle = puzzleManager;
        }

        public override void OnTriggerExit(Collider other) {
            base.OnTriggerExit(other);
            PlayerReference.instance.distributionPuzzle = null;
        }

        public override void Interact() {
            PlayerReference.instance.distributionPuzzle = puzzleManager;
            base.Interact();
        }

    }
}
