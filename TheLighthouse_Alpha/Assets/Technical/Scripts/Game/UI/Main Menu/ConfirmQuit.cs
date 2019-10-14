using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ConfirmQuit : MonoBehaviour
{
    protected PlayerInputActions controls;

    private void Awake() {
        controls = new PlayerInputActions();

        controls.UINavigation.Select.performed += ctx => QuitGame();
        controls.UINavigation.Cancel.performed += ctx => CancelQuit();
    }
    private void OnEnable() {
        controls.UINavigation.Enable();
    }

    public void QuitGame () {
        Application.Quit();
    }

    public void CancelQuit() {
        this.gameObject.SetActive(false);
    }

    private void OnDisable() {
        controls.UINavigation.Disable();
    }
}
