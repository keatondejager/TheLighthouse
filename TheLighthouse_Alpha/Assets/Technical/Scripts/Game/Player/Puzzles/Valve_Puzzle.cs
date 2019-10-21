using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;
using UnityEngine.UI;

public class Valve_Puzzle : MonoBehaviour
{   
    [Header("Object Reference")]
        [SerializeField] protected GameObject ButtonPrompt;
        [Space]
        [SerializeField] protected ParticleSystem steam;
        [SerializeField] protected GameObject steamCollider;

        [SerializeField] protected GameObject UIPrompt;
        [SerializeField] protected Image display;


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
        [SerializeField] protected int FinishPuzzleIndex;

    private PlayerManager manager;
    private bool hasFunction;

    private PlayerInputActions controls;

    [Header("Progress")]
    [SerializeField] protected float progress;
    [SerializeField] protected float decaySpeed = 0.05f;
    [SerializeField] protected float jumpAmount = 0.1f;

    [Header("Feedback")]
    [SerializeField] protected float lowFreq = 0.2f;
    [SerializeField] protected float highFreq = 0.8f;
    [SerializeField] protected float duration = 0.1f;
    [SerializeField] protected float interval = 0.2f;
    [SerializeField] protected int iterations = 1;

    private float displayValue;
    private bool isActive = false;
    private void Update() {
        if (isActive) {
            displayValue = progress;
            if (progress > 0) {
                progress = Mathf.Clamp01(progress - decaySpeed * Time.deltaTime);
            }

            display.fillAmount = displayValue;
        }
    }

    private void Start() {
        controls = new PlayerInputActions();

        controls.PuzzleControls.SecondaryButton.started += ctx => Increase(ctx.control.path);
    }


    private void Increase (string path) {
        progress = Mathf.Clamp01(progress + jumpAmount);
        PlayerReference.instance.ShakeController(path, iterations, duration, interval, lowFreq, highFreq);
        if (progress > 0.95f) {
            state = ValveState.Installed_Closed;
            CompletePuzzle();
            PlayerReference.instance.manager.PuzzleExit();
        }
    }
    

    public void ClosePuzzleUI () {
        isActive = false;
        UIPrompt.SetActive(false);
        controls.PuzzleControls.Disable();
    }

    public void OpenPuzzleUI () {
        isActive = true;
        UIPrompt.SetActive(true);
        controls.PuzzleControls.Enable();
        progress = 0;
    }


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
        NarrativeController.instance.TriggerNarrative(FinishPuzzleIndex);
        steamCollider.SetActive(false);
        ButtonPrompt.SetActive(false);
        PlayerReference.instance.puzzleSteamComplete = true;
        UIPrompt.SetActive(false);
    }
}
