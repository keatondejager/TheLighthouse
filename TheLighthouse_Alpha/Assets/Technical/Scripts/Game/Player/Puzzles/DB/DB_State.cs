using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class DB_State : MonoBehaviour
{
    [SerializeField] protected GameObject UIPrompt;
    protected Player.PlayerManager manager;
    protected DistributionBoard puzzleManager;

    protected bool hasRequirement;
    protected PlayerInputActions controls;

    public virtual void Initialize(DistributionBoard myManager) {
        manager = Player.PlayerReference.instance.manager;
        puzzleManager = myManager;
        controls = new PlayerInputActions();

        controls.PuzzleControls.Close.performed += ctx => manager.UniversalExit();
        ControlsSetUp();
    }

    public virtual void Step () {

    }

    public virtual void ControlsSetUp() {
        controls.PuzzleControls.PrimaryButton.performed += ctx => Debug.Log("X");
    }

    public virtual bool CheckRequirement () {
        if (hasRequirement) {
            //Check if the player has the required thing
            return false; // or false
        }

        return true;
    }

    private void OnEnable() {
        controls.PuzzleControls.Enable();    
        EnableState();
    }

    private void OnDisable() {
        controls.PuzzleControls.Disable();
        DisableState();
    }

    public virtual void EnableState () {
        //Enable UI prompts
        UIPrompt.SetActive(true);
    }

    public virtual void DisableState () {
        // Disable UI prompts
        UIPrompt.SetActive(false);
    }
}
