using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Wires : DB_State
{
    [Header("State Reference")]
        [SerializeField] protected GameObject switchObject;
        [Range(-1, 1)] [SerializeField] protected int pullDirection;

    [Header("Input Reference")]
        [SerializeField] protected bool isRightGrabDown;
        [SerializeField] protected bool isLeftGrabDown;
        [SerializeField] protected float analogueInput;

    [Header("Progress Control")]
        [SerializeField] protected float pullSpeed = 0.01f;
        [SerializeField] protected float finalPoint;
        [SerializeField] protected float currentProgress;
        [SerializeField] protected float ErrorMargin = 0.2f;
        [SerializeField] protected Slider ProgressDisp;

    public override void Initialize(DistributionBoard myManager) {
        base.Initialize(myManager);
        
        if (pullDirection == 0) {
            pullDirection = 1;
        }
        finalPoint = Mathf.Abs(finalPoint) * pullDirection;

    }

    public override void ControlsSetUp() {
        controls.PuzzleControls.RightGrab.performed += ctx => isRightGrabDown = true;
        controls.PuzzleControls.RightGrab.canceled += ctx => isRightGrabDown = false;

        controls.PuzzleControls.LeftGrab.performed += ctx => isLeftGrabDown = true;
        controls.PuzzleControls.LeftGrab.canceled += ctx => isLeftGrabDown = false;

        controls.PuzzleControls.SecondaryAxis.performed += ctx => analogueInput = ctx.ReadValue<Vector2>().y;
        controls.PuzzleControls.SecondaryAxis.canceled += ctx => analogueInput = 0;
    }

    public override void Step() {
        if (!isLeftGrabDown || !isRightGrabDown || analogueInput == 0) {
            return;
        }

        if (pullDirection < 0) {
            analogueInput = Mathf.Clamp(analogueInput, -1, 0);
        } else {
            analogueInput = Mathf.Clamp(analogueInput, 0, 1);
        }

        currentProgress += analogueInput * pullSpeed;

        ProgressDisp.value = currentProgress / finalPoint;

        if (Mathf.Abs(currentProgress - finalPoint) < ErrorMargin) {
            PullComplete();
        }
    }

    private void PullComplete () {
        switchObject.SetActive(false);
        puzzleManager.StateComplete();
    }


    
}
