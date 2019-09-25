using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitBoardItem2 : MonoBehaviour
{
    private bool OnItem = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("On Item");
            OnItem = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("On Item");
            OnItem = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (OnItem)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (GameObject.Find("Inv").GetComponent<PlayerInventory>().myInventory[1] == true)
                {
                    GameObject.Find("Item2InWall").GetComponent<MeshRenderer>().enabled = true;
                }
            }
        }
    }
}
