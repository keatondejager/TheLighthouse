using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_Item : MonoBehaviour
{
    public Image Icon;
    public TMP_Text NameDisplay;
    public Item content;

    private void OnEnable() {
        Icon.sprite = content.imageIcon;
        NameDisplay.text = content.name;
    }

}
