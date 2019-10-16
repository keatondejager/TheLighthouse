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
        [Range(-1, 1)] [SerializeField] protected float direction = 1;
        [SerializeField] protected float y_direction;
        [SerializeField] protected float x_direction;

    [Header("Progress Control")]
        [SerializeField] protected int accuracyIndex = 0;
        [SerializeField] protected float currentProgress;
        [SerializeField] protected float updateRate = 0.2f;
        [SerializeField] protected float rotationSpeed = 0.2f;
        [SerializeField] protected int numberRotations = 1;
        private int currentRotationCount = 0;

    [Header("Additional Calculations")]
        [SerializeField] protected float delayedAngle = 0;
        [SerializeField] protected float input_value = 0;
        [SerializeField] protected float speedController = 0;

    [Header("Progress Tracking")]
        public Image myPosition;
        public Image upperLimit;
        public Image lowerLimit;

    [Header("Controller Path")]
        private string inputPath;
       
    public override void Initialize (DistributionBoard myManager) {
        base.Initialize(myManager);
        currentProgress = 0;   
        x_direction = direction;
        y_direction = -direction;
    }

    public override void Step () {
        TakeReadings();
        currentProgress = Mathf.Lerp(currentProgress, (Mathf.Clamp(accuracyIndex - 1, 0, accuracy.Count) * 1.0f) / accuracy.Count, updateRate);
        progressDisp.fillAmount = currentProgress;
    }

    public override void ControlsSetUp() {
        controls.PuzzleControls.PrimaryAxis.performed += ctx => AnalogueInput = ctx.ReadValue<Vector2>();
        controls.PuzzleControls.PrimaryAxis.performed += ctx => inputPath = ctx.control.path;
        controls.PuzzleControls.PrimaryAxis.canceled += ctx => AnalogueInput = Vector2.zero;

        controls.PuzzleControls.Enable();
    }

    protected void TakeReadings () {
        if (AnalogueInput.sqrMagnitude == 0) {
            return;
        }

        if (Vector2.Distance(AnalogueInput.normalized, accuracy[accuracyIndex].normalized) < errorMargin) {
            accuracyIndex++; 
            Player.PlayerReference.instance.ShakeController(inputPath, 1); 
            Debug.Log(inputPath);
            if (accuracyIndex >= accuracy.Count) {
                accuracyIndex = 0;
                FullRotation();
            }
        }
        // AnalogueInput.Normalize();
        // float x = AnalogueInput.x;
        // float y = AnalogueInput.y;

        // float angle = Mathf.Atan(y/x);
        // if (angle < 0) {
        //     angle += Mathf.PI;
            
        // }
        // angle += y < 0 ? Mathf.PI : 0;

        // float zeroToOne = Remap(angle);

        // speedController += rotationSpeed * Time.deltaTime; 
        // if (speedController > 1) {
        //     speedController = 0;
        // }

        // if (Mathf.Abs(zeroToOne - speedController) < errorMargin) {
        //     delayedAngle += rotationSpeed * Time.deltaTime;
        // } else {
        //     Player.PlayerReference.instance.ShakeController(inputPath, 1);
        // }

        // progressDisp.fillAmount = delayedAngle;

        // myPosition.fillAmount = zeroToOne;
        // float upperNumber = speedController + errorMargin;
        // float lowerNumber = speedController - errorMargin;
         
        // upperLimit.fillAmount = upperNumber;
        // lowerLimit.fillAmount = lowerNumber;

        // if (delayedAngle > 1) {
        //     FullRotation();
        // }
    }

    private float Remap(float value, float from1 = 0, float to1 = 2 * Mathf.PI, float from2 = 0, float to2 = 1) {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
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
