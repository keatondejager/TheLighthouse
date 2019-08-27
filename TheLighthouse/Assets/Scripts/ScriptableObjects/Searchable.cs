using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Searchable Object", menuName = "Searchable Object")]
public class Searchable : ScriptableObject
{
    public new string name;
    public string description;
    public List<Item> inventory;
}
