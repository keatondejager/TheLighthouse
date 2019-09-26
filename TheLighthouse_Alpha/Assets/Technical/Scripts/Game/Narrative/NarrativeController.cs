using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class NarrativeController : MonoBehaviour
{
    [SerializeField] protected List<NarrativeObject> Story;
    [SerializeField] protected AudioSource VoiceLineSource;
    [SerializeField] protected TMP_Text subtitleSource;

    [SerializeField] protected int storyIndex;

}
