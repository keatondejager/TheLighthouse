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
        }
    }

    private void OnEnable() {
        ControllerSettings.instance.OnSpriteChange += SetImage;
    }

    private void OnDisable() {
        ControllerSettings.instance.OnSpriteChange -= SetImage;
    }
}
