using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Inventory Item", menuName = "Item")]
public class Item : ScriptableObject
{
   public new string name;
   public string description;
   public Sprite icon;
   
}
