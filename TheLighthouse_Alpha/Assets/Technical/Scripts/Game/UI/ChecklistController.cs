using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChecklistController : MonoBehaviour
{
    public List<Image> CheckBox;
    public List<Item> Items;
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

    public void SetSprite () {
        for (int i = 0; i < Items.Count; i++) {
            if (Player.PlayerReference.instance.PlayerInventory.Contains(Items[i])) {
                CheckBox[i].sprite = CheckMark;
            } else {
                CheckBox[i].sprite = EmptyBox;
            }
        } 
    }

    private void OnEnable() {
        SetSprite();
        Player.PlayerReference.instance.OnInventoryChange += SetSprite;
    }

    private void OnDisable() {
        Player.PlayerReference.instance.OnInventoryChange -= SetSprite;
    }


}
