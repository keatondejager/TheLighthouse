using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChecklistController : MonoBehaviour
{
    public List<bool> hasItemList;
    public List<Image> CheckBox;
    public Sprite CheckMark;
    public Sprite EmptyBox;
    public Image myImage;

    private bool isVisible = false;

    public void EnableCheckBox () {
        isVisible = true;
    }

    private void Update() {
        if (isVisible) {
            myImage.color = Color.Lerp(myImage.color, Color.white, Time.deltaTime);
        }
    }


}
