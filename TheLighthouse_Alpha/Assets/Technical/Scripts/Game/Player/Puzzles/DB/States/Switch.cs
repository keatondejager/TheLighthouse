using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : DB_State {
    
    [Header("State Reference")]
    [SerializeField] protected bool isPlacing;

    [SerializeField] protected GameObject SwitchObject;

    [Header("Input Reference")]
        [SerializeField] protected bool isRightGrabDown;
        [SerializeField] protected bool isLeftGrabDown;
        [SerializeField] protected float analogueInput_L;
        [SerializeField] protected float analogueInput_R;
    
    [Header("Progress Control")]
        [SerializeField] protected float pullSpeed = 0.02f;
        [SerializeField] protected float currentProgress;
        [SerializeField] protected Image ProgressDisp;


    public override void Initialize(DistributionBoard myManager) {
        base.Initialize(myManager);

    }

    public override void ControlsSetUp() {
        if (isPlacing) {
            controls.PuzzleControls.TertiaryButton.started += ctx => CompleteState ();
        } else {
            controls.PuzzleControls.RightGrab.started += ctx => isRightGrabDown = true;
            controls.PuzzleControls.RightGrab.canceled += ctx => isRightGrabDown = false;

            controls.PuzzleControls.LeftGrab.started += ctx => isLeftGrabDown = true;
            controls.PuzzleControls.LeftGrab.canceled += ctx => isLeftGrabDown = false;

            controls.PuzzleControls.PrimaryAxis.performed += ctx => analogueInput_L = ctx.ReadValue<Vector2>().magnitude;
            controls.PuzzleControls.PrimaryAxis.canceled += ctx => analogueInput_L = 0;

            controls.PuzzleControls.SecondaryAxis.performed += ctx => analogueInput_R = ctx.ReadValue<Vector2>().magnitude;
            controls.PuzzleControls.SecondaryAxis.canceled += ctx => analogueInput_R = 0;
        }
    }

    public override void Step() {
        if (analogueInput_R == 0 || analogueInput_L == 0 || !isLeftGrabDown || !isRightGrabDown || isPlacing) {
            return;
        }

        float analogueInput = Mathf.Clamp01((analogueInput_L + analogueInput_R) / 2.0f);
        currentProgress += analogueInput * pullSpeed;

        ProgressDisp.fillAmount = currentProgress;

        if (currentProgress >= 1f) {
            CompleteState();
        }

    }

    private void CompleteState () {
        SwitchObject.SetActive(isPlacing);
        puzzleManager.StateComplete();
    }

}
