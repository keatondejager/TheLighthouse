using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Screws : DB_State
{
    [Header("Object Reference")]
        [SerializeField] protected Image progressDisp;
        [SerializeField] protected GameObject myScrewObject;

    [Header("Screw State Control")]
        [SerializeField] protected bool stateDirection; // True = Inserting screws, False = Removing Screws
        [SerializeField] protected Vector2 AnalogueInput;

    [Header("Value Reference")]
        [SerializeField] protected List<Vector2> accuracy;
        [SerializeField] protected float errorMargin = 0.4f;

    [Header("Progress Control")]
        [SerializeField] protected int accuracyIndex = 0;
        [SerializeField] protected float currentProgress;
        [SerializeField] protected float updateRate = 0.2f;
        [SerializeField] protected int numberRotations = 1;
        private int currentRotationCount = 0;


    public override void Initialize (DistributionBoard myManager) {
        base.Initialize(myManager);
        currentProgress = 0;   
    }

    public override void Step () {
        TakeReadings();
        currentProgress = Mathf.Lerp(currentProgress, (Mathf.Clamp(accuracyIndex - 1, 0, accuracy.Count) * 1.0f) / accuracy.Count, updateRate);
        progressDisp.fillAmount = currentProgress;
    }

    public override void ControlsSetUp() {
        controls.PuzzleControls.PrimaryAxis.performed += ctx => AnalogueInput = ctx.ReadValue<Vector2>();
        controls.PuzzleControls.PrimaryAxis.canceled += ctx => AnalogueInput = Vector2.zero;

        controls.PuzzleControls.Enable();
    }

    protected void TakeReadings () {
        if (AnalogueInput.sqrMagnitude == 0) {
            return;
        }

        if (Vector2.Distance(AnalogueInput.normalized, accuracy[accuracyIndex].normalized) < errorMargin) {
            accuracyIndex++;
            if (accuracyIndex >= accuracy.Count) {
                accuracyIndex = 0;
                FullRotation();
            }
        }
    }

    private void FullRotation () {
        currentRotationCount++;
        currentProgress = 0;
        if (currentRotationCount >= numberRotations) {
            myScrewObject.SetActive(stateDirection);
            puzzleManager.StateComplete ();
        }
    }


}
