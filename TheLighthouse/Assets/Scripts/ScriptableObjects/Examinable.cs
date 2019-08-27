using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Examinable Object", menuName = "Examinable Object")]
public class Examinable : ScriptableObject
{
    public new string name;
    public string description;
    public Transform mesh;
    public Vector3 originalPosition;
    public Vector3 originalRotation;
    
}
