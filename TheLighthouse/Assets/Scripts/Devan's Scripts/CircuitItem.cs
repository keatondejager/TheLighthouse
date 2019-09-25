using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitItem : MonoBehaviour
{
    private bool OnItem = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("On item");
            OnItem = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnItem = false;
        }
    }

    void Update()
    {
        if (OnItem)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                Debug.Log("Taken item");
                if (this.gameObject.name.CompareTo("Item1") == 0)
                {
                    Destroy(GameObject.Find("Item1"));
                    GameObject.Find("Inv").GetComponent<PlayerInventory>().AddItemtoInv(0);
                }
                else if (this.gameObject.name.CompareTo("Item2") == 0)
                {
                    Destroy(GameObject.Find("Item2"));
                    GameObject.Find("Inv").GetComponent<PlayerInventory>().AddItemtoInv(1);
                }
                else if(this.gameObject.name.CompareTo("Item3") == 0)
                {
                    Destroy(GameObject.Find("Item3"));
                    GameObject.Find("Inv").GetComponent<PlayerInventory>().AddItemtoInv(2);
                }
                
            }
        }
    }
}
