using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{

    public GameObject mainMenu;
    private PlayerInputActions controls;
    private void Awake() {
        controls = new PlayerInputActions();

        controls.OptionsMenu.Back.performed += ctx => OptionsClose();
    }

    private void OptionsClose () {
        mainMenu.SetActive(true);

        this.gameObject.SetActive(false);
    }

    private void OnEnable() {
        controls.OptionsMenu.Enable();
    }

    private void OnDisable() {
        controls.OptionsMenu.Disable();
    }
}
