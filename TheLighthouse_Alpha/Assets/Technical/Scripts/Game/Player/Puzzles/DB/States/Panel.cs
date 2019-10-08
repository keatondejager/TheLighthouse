using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Panel : DB_State {

    [Header("State Reference")]
        [SerializeField] protected Transform PanelObject; // The front panel transform to move the object
        [Range(0.01f,1f)] [SerializeField] protected float movementScale = 0.01f; //The amount of time taken to move the panel from open to closed
        [SerializeField] protected bool isOpening; // True if the panel is tending to the open position

    [Header("Input Controls")]
        [SerializeField] protected bool isGrabButtonDown = false;
        [SerializeField] protected float analogueInput = 0;

    [Header("Object Control")]
        [SerializeField] protected float panelOffset = 0;
        [SerializeField] protected Vector3 onPosition;
        [SerializeField] protected Vector3 offPosition;
        private float offsetDistance;
    
    [Header("Progression")]
        [SerializeField] protected float errorMargin = 0.2f;
        [SerializeField] protected Vector3 startPosition;
        [SerializeField] protected Vector3 endPosition;
        [SerializeField] protected Slider ProgressDisplay;

    public override void Initialize(DistributionBoard myManager) {
        base.Initialize(myManager);
        offsetDistance = Vector3.Distance(onPosition, offPosition);

        if (isOpening) {
            startPosition = onPosition;
            endPosition = offPosition;
        } else {
            startPosition = offPosition;
            endPosition = onPosition;
        }

    }

    public override void ControlsSetUp() {
        controls.PuzzleControls.LeftGrab.started += ctx => isGrabButtonDown = true; // Holding L2
        controls.PuzzleControls.LeftGrab.canceled += ctx => isGrabButtonDown = false; // Not Holding L2

        controls.PuzzleControls.PrimaryAxis.performed += ctx => analogueInput = -ctx.ReadValue<Vector2>().x;
        controls.PuzzleControls.PrimaryAxis.canceled += ctx => analogueInput = 0;
    }

    public override void Step() {
        if (analogueInput == 0 || !isGrabButtonDown) {
            return;
        }

        if(isOpening) {
            analogueInput = Mathf.Clamp(analogueInput, 0, 1);
        } else {
            analogueInput = Mathf.Clamp(analogueInput, -1, 0);
        }

        panelOffset += (analogueInput * movementScale);

        
        PanelObject.localPosition = startPosition + (panelOffset * Mathf.Abs(offsetDistance) * Vector3.right);
       
        ProgressDisplay.value = Mathf.Abs(panelOffset);

        if ( Vector3.Distance(PanelObject.localPosition , endPosition) < errorMargin) {
            MoveDone();
        }
    }

    private void MoveDone () {
        puzzleManager.StateComplete();
    }



}
