using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class NarrativeController : MonoBehaviour
{

    public static NarrativeController instance;

    [SerializeField] protected List<NarrativeObject> Story;
    [SerializeField] protected AudioSource VoiceLineSource;
    [SerializeField] protected TMP_Text subtitleSource;

    private List<int> cuesTriggered;
    private float subtitleClearDelay;
    private AudioClip toPlay;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this.gameObject);
        }

        cuesTriggered = new List<int>();
    }

    public void TriggerNarrative (int cueIndex) {
        if (cuesTriggered.Contains(cueIndex)) {
            return;
        }
        if (!Story[cueIndex].Repeatable) {
            cuesTriggered.Add(cueIndex); 
        }

        subtitleSource.text = Story[cueIndex].subtitle;
        if (Story[cueIndex].voiceLine != null) {
            toPlay = Story[cueIndex].voiceLine; 
        }

        if (Story[cueIndex].duration > 0) {
            subtitleClearDelay = Story[cueIndex].duration;
        } else {
            subtitleClearDelay = Story[cueIndex].voiceLine != null ? Story[cueIndex].voiceLine.length + 1f : Story[cueIndex].subtitle.Length / 8f;
        }
        
    }

    private void Update() {
        if (toPlay != null) {
            if (!VoiceLineSource.isPlaying) {
                VoiceLineSource.clip = toPlay;
                VoiceLineSource.Play();
                toPlay = null;
            } 
        }

        if (subtitleClearDelay > 0) {
            subtitleClearDelay -= Time.deltaTime;
        } else {
            subtitleSource.text = "";
        }

    }

}
