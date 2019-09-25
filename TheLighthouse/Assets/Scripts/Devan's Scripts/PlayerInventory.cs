using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<bool> myInventory = new List<bool>(3);

    private void Start()
    {
        myInventory.Capacity = 3;
        myInventory[0] = false;
        myInventory[1] = false;
        myInventory[2] = false;
    }

    public void AddItemtoInv(int slot)
    {
        myInventory[slot] = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
