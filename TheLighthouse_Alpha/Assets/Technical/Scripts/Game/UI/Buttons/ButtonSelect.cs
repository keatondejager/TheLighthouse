using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ButtonSelect : MonoBehaviour
{
    [Header("Object Reference")]
        public BetterButton[] Buttons;
    
    [Header("Control")]
        private int buttonIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.Tab) || Input.GetKeyDown(KeyCode.RightArrow)){
            buttonIndex++;
            if (buttonIndex >= Buttons.Length) {
                buttonIndex = 0;
            }
            UpdateButtons();
        } else if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow)) {
            buttonIndex --;
            if (buttonIndex < 0) {
                buttonIndex = Buttons.Length - 1;
            }
            UpdateButtons();
        }
    }

    public void UpdateButtons() {
        foreach (BetterButton button in Buttons) {
            button.Deactivate();
        }
        Buttons[buttonIndex].Activate();
    }
}
