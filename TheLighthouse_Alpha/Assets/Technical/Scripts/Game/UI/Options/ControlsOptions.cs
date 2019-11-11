using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ControlsOptions : MonoBehaviour
{   

    public TMP_Text ActiveTypeDisp;
    public AudioSource SoundEffect;
    public enum ControllerType {
        PS4 = 0, XBox = 1
    }

    public ControllerType activeController = ControllerType.PS4;
    private PlayerInputActions controls;

    private void Awake() {
        controls = new PlayerInputActions();

        controls.OptionsMenu.Right.started += ctx => ToggleType ();
        controls.OptionsMenu.Left.started += ctx => ToggleType();
    }

    private void OnEnable() {
        if (activeController == ControllerType.PS4) {
            ActiveTypeDisp.text = "Dualshock4";
            
        } else {
            ActiveTypeDisp.text = "XBox / Microsoft";
            
        }
        controls.OptionsMenu.Enable();
    }

    private void OnDisable() {
        controls.OptionsMenu.Disable();
    }

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        
    }

    private void ToggleType() {
        activeController = activeController == ControllerType.PS4 ? ControllerType.XBox : ControllerType.PS4;

        if (activeController == ControllerType.PS4) {
            ActiveTypeDisp.text = "Dualshock4";
            
        } else {
            ActiveTypeDisp.text = "XBox / Microsoft";
            
        }
        SoundEffect.Play();
        ControllerSettings.instance.SetControllerType((int)activeController);
    }


}
