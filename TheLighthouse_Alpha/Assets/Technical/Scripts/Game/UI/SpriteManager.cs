using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SpriteManager : MonoBehaviour
{
    public Image myImage;
    
    public enum ButtonOption {
        North, South, East, West, RShoulder, LShoulder, RTrigger, LTrigger
    }

    public ButtonOption type;

    // Start is called before the first frame update
    void Start() {
        if (!myImage) {
            myImage = GetComponent<Image>();
        }

        SetImage();
    }

    private void SetImage () {
        switch (type) {
            case ButtonOption.North:
                myImage.sprite = ControllerSettings.instance.North;
            break;
            case ButtonOption.South:
                myImage.sprite = ControllerSettings.instance.South;
            break;
            case ButtonOption.East:
                myImage.sprite = ControllerSettings.instance.East;
            break;
            case ButtonOption.West:
                myImage.sprite = ControllerSettings.instance.West;
            break;
            case ButtonOption.RShoulder:
                myImage.sprite = ControllerSettings.instance.RightShoulder;
            break;
            case ButtonOption.LShoulder:
                myImage.sprite = ControllerSettings.instance.LeftShoulder;
            break;
            case ButtonOption.RTrigger:
                myImage.sprite = ControllerSettings.instance.RightTrigger;
            break;
            case ButtonOption.LTrigger:
                myImage.sprite = ControllerSettings.instance.LeftTrigger;
            break;
        }
    }

    private void OnEnable() {
        ControllerSettings.instance.OnSpriteChange += SetImage;

         if (!myImage) {
            myImage = GetComponent<Image>();
        }

        SetImage();
    }

    private void OnDisable() {
        ControllerSettings.instance.OnSpriteChange -= SetImage;
    }
}
