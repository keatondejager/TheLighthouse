using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircuitBoardItem3 : MonoBehaviour
{
    private bool OnItem = false;
    bool doorOpened = false;

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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OnItem)
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                if (GameObject.Find("Inv").GetComponent<PlayerInventory>().myInventory[2] == true)
                {
                    GameObject.Find("Item3InWall").GetComponent<MeshRenderer>().enabled = true;
                }
            }
        }


        if (GameObject.Find("Item1InWall").GetComponent<MeshRenderer>().enabled && GameObject.Find("Item2InWall").GetComponent<MeshRenderer>().enabled && GameObject.Find("Item3InWall").GetComponent<MeshRenderer>().enabled)
        {
            if(doorOpened == false)
            {
                doorOpened = true;
                GameObject.Find("EXIT DOOR").transform.Rotate(0, 90, 0);
            }
            
        }
    }
}
