using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class Valve_Puzzle : MonoBehaviour
{   
    [Header("Object Reference")]
        [SerializeField] protected GameObject ButtonPrompt;
        [Space]
        [SerializeField] protected ParticleSystem steam;
        [SerializeField] protected GameObject steamCollider;

        [SerializeField] protected GameObject UIPrompt;


    [Header("State Control")]
        [SerializeField] protected ValveState state = ValveState.NoValve;
        public enum ValveState {
            NoValve = 0, NoWrench = 1, NeedsTightening = 2, Installed_Open = 3, Installed_Closed = 4
        }

    [Header("Item Reference")]
        [SerializeField] protected Item ValveItem; 
        [SerializeField] protected Item WrenchItem;
    [Header("Narrative Reference")]
        [SerializeField] protected int NoWrenchLineIndex;
        [SerializeField] protected int NoValveLineIndex;
        [SerializeField] protected int OpeningPuzzleLineIndex;

    private PlayerManager manager;
    private bool hasFunction;





    private void OnTriggerEnter(Collider other) {
        if (steam.isStopped || state == ValveState.Installed_Closed) {
            return;
        }
        var obj = other.GetComponent<PlayerManager>();
        if (obj is PlayerManager) {
            if (!manager) {
                manager = obj;
            }
            if (!hasFunction) {
                manager.OnInteractEnter += Interact;
                hasFunction = true;
            }
            ButtonPrompt.SetActive(hasFunction);
        }
    }

    private void OnTriggerExit(Collider other) {
        var obj = other.GetComponent<PlayerManager>();
        if (obj is PlayerManager) {
            if (!manager) {
                manager = obj;
            }
            if (hasFunction) {
                manager.OnInteractEnter -= Interact;
                hasFunction = false;
            }
            ButtonPrompt.SetActive(hasFunction);
        }
    }

    private void Interact () {
        // Open Puzzle Menu, set player to puzzle state. 

        if (state == ValveState.NoValve) {
            if (PlayerReference.instance.PlayerInventory.Contains(ValveItem)){
                state = ValveState.NoWrench;
            }
        }

        if (state == ValveState.NoWrench) {
            if (PlayerReference.instance.PlayerInventory.Contains(WrenchItem)) {
                state = ValveState.NeedsTightening;
            }
        }


        switch (state) {
            case ValveState.NoValve:
                // Run dialogue line
                NarrativeController.instance.TriggerNarrative(NoValveLineIndex);
            break;
            case ValveState.NoWrench:
                // Run dialogue line
                NarrativeController.instance.TriggerNarrative(NoWrenchLineIndex);
            break;
            case ValveState.NeedsTightening:
                // Open puzzle state and allow for analogue rotations 
                NarrativeController.instance.TriggerNarrative(OpeningPuzzleLineIndex);

                PlayerReference.instance.manager.PuzzleEnter();
                UIPrompt.SetActive(true);
            break;
            case ValveState.Installed_Open:
                // Open puzzle state and allow for analogue rotations

                PlayerReference.instance.manager.PuzzleEnter();
            break;
            case ValveState.Installed_Closed:
                // This shouldnt happen
                if (!steam.isStopped) {
                    steam.Stop();
                }
                UIPrompt.SetActive(false);
            break;
        }

    }   

    private void CompletePuzzle () {
        steam.Stop();
        steamCollider.SetActive(false);
        ButtonPrompt.SetActive(false);
        PlayerReference.instance.puzzleSteamComplete = true;
        UIPrompt.SetActive(false);
    }
}
