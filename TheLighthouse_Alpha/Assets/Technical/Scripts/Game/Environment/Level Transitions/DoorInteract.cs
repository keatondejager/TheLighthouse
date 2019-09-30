using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;

public class DoorInteract : MonoBehaviour
{
    [Header("Trigger Settings")]
        [SerializeField] protected BoxCollider objectCollider;
        [SerializeField] protected BoxCollider triggerCollider;
        [Range(1, 5)] [SerializeField] protected float triggerScale = 1;

    [Header("Door Conditions")]
        [SerializeField] protected Requirement doorCondition = Requirement.None;

    [Header("Reference")]
        [SerializeField] protected GameObject buttonPrompt;
        [SerializeField] protected LevelManager levelManager;

        public enum Requirement {None = 0, Puzzle_1 = 1, Puzzle_2 = 2}
    // Start is called before the first frame update
    void Start()
    {   
        triggerCollider.isTrigger = true;
        triggerCollider.size = objectCollider.size * triggerScale;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            bool conditionMet = doorCondition == Requirement.Puzzle_1 && PlayerReference.instance.puzzleOneComplete;
            conditionMet = conditionMet || (doorCondition == Requirement.Puzzle_2 && PlayerReference.instance.puzzleTwoComplete);
            conditionMet = conditionMet || doorCondition == Requirement.None;

            PlayerReference.instance.canDoTransition = conditionMet;
            if (conditionMet) {
                PlayerReference.instance.manager.OnInteractEnter += OpenDoor;
            }

            buttonPrompt.SetActive(conditionMet);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            if (PlayerReference.instance.canDoTransition) {
                PlayerReference.instance.manager.OnInteractEnter -= OpenDoor;
            }
            PlayerReference.instance.canDoTransition = false;
            buttonPrompt.SetActive(false);
        }
    }

    public void OpenDoor () {
        levelManager.DoLevelTransition();
    }
}
