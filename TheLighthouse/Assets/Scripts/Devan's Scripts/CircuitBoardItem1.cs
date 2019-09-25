using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitBoardItem1 : MonoBehaviour
{
    private bool OnItem = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("On Item in wall 1");
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

    // Update is called once per frame
    void Update()
    {
        if (OnItem)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (GameObject.Find("Inv").GetComponent<PlayerInventory>().myInventory[0] == true)
                {
                    GameObject.Find("Item1InWall").GetComponent<MeshRenderer>().enabled = true;
                }
            }
        }
    }
}
