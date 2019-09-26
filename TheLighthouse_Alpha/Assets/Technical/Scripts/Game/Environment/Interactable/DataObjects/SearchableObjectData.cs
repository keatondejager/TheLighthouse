using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/Searchable Inventory", fileName = "Object Inventory")]
public class SearchableObjectData : ScriptableObject
{
    public string InventoryObjectName = "";
    
    // List of items in the inventory
    [SerializeField] protected List<Item> _inventory;
    [SerializeField] protected List<Item> defaultInventory;
    public List<Item> inventory {
        get => _inventory;
    }

    // Reference to the UI list containing the buttons for the items, or the specific UI element for this object.

    // Narrative Cue to trigger?

    //Inventory Interactions 
    public void RemoveItem (int ItemIndex) {
        if (_inventory.Count > ItemIndex) {
            return;
        }

        _inventory.RemoveAt(ItemIndex);
    }

    public void RemoveItem (Item item) {
        if (!_inventory.Contains(item)) {
            return;
        }

        _inventory.Remove(item);
    }

    public void AddItem (Item item) {
        if (_inventory.Contains(item)) {
            return;
        }

        _inventory.Add(item);
    }

    public void ResetInventory () {
        _inventory.Clear();
        foreach (Item item in defaultInventory) {
            _inventory.Add(item);
        }
    }

    private void OnEnable() {
        ResetInventory();
    }
}
