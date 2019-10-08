using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Narrative/Narrative Content", fileName = "Narrative Information")]
public class NarrativeObject : ScriptableObject
{
    public AudioClip voiceLine;
    public string subtitle;
    public float duration;
    public bool Repeatable;
}
