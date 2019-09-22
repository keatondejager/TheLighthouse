using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchableUIDisplay : MonoBehaviour
{
    public List<GameObject> Content = new List<GameObject>();
    public GameObject ItemHolder;
    
    public void AddObject(GameObject obj)
    {
        Content.Add(obj);
        Open();
    }
    
    public void Open()
    {
        foreach (GameObject item in Content)
        {
            item.gameObject.transform.parent = this.gameObject.transform;
        }
    }

    public void RemoveAllObjects()
    {
        foreach (GameObject item in Content)
        {
            item.gameObject.transform.parent = ItemHolder.transform;
            Content.Remove(item);
        }
    }
}
