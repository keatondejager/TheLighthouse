using UnityEngine;

[CreateAssetMenu(menuName = "Items/Item", fileName = "Item #0")]
public class Item : ScriptableObject
{

    [Header("UI Reference")]
        public new string name = "Item";
        public Sprite imageIcon;

    [Header("Data Reference")]
        public int itemCode = 0;
    
}
