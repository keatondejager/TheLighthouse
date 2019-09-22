using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchableObject : MonoBehaviour
{
    public List<GameObject> Content = new List<GameObject>();
    public SearchableUIDisplay SUID;
    // Start is called before the first frame update
    void Start()
    {
        //SUID = FindObjectOfType<SearchableUIDisplay>();
    }

    public void Open()
    {
        foreach (GameObject item in Content)
        {
            SUID.AddObject(item);
        }
    }

    public void Close()
    {
        SUID.RemoveAllObjects();
    }
}
