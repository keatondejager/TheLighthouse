using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class ButtonNavigation : MonoBehaviour
{
    public List<BetterBtn> buttonOptions;
    public int defaultIndex;

    private int currentIndex;

    private PlayerInputActions controls;
    private int problemCount = 0;

    private void Start() {
        controls.UINavigation.Down.performed += ctx => NavigateDown();
        controls.UINavigation.Up.performed += ctx => NavigateUp();
        controls.UINavigation.Select.performed += ctx => SelectButton();
    }

    private void NavigateUp () {
        if (buttonOptions.Count == 0) {
            return;
        }
        problemCount++;
        if (problemCount >= buttonOptions.Count) {
            return;
        }
        buttonOptions[currentIndex].Deactivate();

        currentIndex--; 
        if (currentIndex < 0) {
            currentIndex = buttonOptions.Count - 1;
        }

        if (!buttonOptions[currentIndex].gameObject.activeInHierarchy) {
            NavigateUp();
        }
        problemCount = 0;
        buttonOptions[currentIndex].Activate();
        
    }

    private void NavigateDown() {
        if (buttonOptions.Count == 0) {
            return;
        }
        problemCount++;
        if (problemCount >= buttonOptions.Count) {
            return;
        }
        buttonOptions[currentIndex].Deactivate();

        currentIndex++;
        if (currentIndex >= buttonOptions.Count) {
            currentIndex = 0;
        }
        
        if (!buttonOptions[currentIndex].gameObject.activeInHierarchy) {
            
            NavigateDown();
        }
        problemCount = 0;
        buttonOptions[currentIndex].Activate();

        
    }

    private void SelectButton () {
        if (buttonOptions.Count == 0) {
            return;
        }
        buttonOptions[currentIndex].Submit();
    }

    private void OnEnable() {
        
        if (controls == null) {
            controls = new PlayerInputActions();
        }

        controls.UINavigation.Enable();
        ActivateDefault();
    }

    public void ActivateDefault () {
        if (buttonOptions.Count == 0) {
            return;
        }
        problemCount++;
        if (problemCount >= buttonOptions.Count) {
            return;
        }
        currentIndex = 0;

        if (!buttonOptions[currentIndex].gameObject.activeInHierarchy) {
            NavigateDown();
        }
        problemCount = 0;
        buttonOptions[currentIndex].Activate();
    }

    private void OnDisable() {
        controls.UINavigation.Disable();
    }
    

}
