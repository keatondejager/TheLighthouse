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
    private float timestamp;
    private List<NarrativeObject> queue;
    private bool interrupted;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this.gameObject);
        }

        cuesTriggered = new List<int>();
        queue = new List<NarrativeObject>();
    }

    public void TriggerNarrative (int cueIndex) {
        if (cuesTriggered.Contains(cueIndex) || queue.Contains(Story[cueIndex])) {
            return;
        }
        if (!Story[cueIndex].Repeatable) {
            cuesTriggered.Add(cueIndex); 
        }

        if (Story[cueIndex].priority > 100) {
            Interupt(Story[cueIndex]);
            return;
        }

        if (queue.Count > 0) {
            if (Story[cueIndex].priority > 0) {
                if (Story[cueIndex].priority > 9) {
                    queue.Insert(0, Story[cueIndex]);
                } else if (queue.Count < 2) {
                    queue.Add(Story[cueIndex]);
                }
            }
            return;
        }
        queue.Add(Story[cueIndex]);    
    }

    private void Interupt (NarrativeObject interupter) {
        queue.Insert(0, interupter);
        VoiceLineSource.Stop();
    }

    private void Update() {
        // if (toPlay != null) {
        //     if (!VoiceLineSource.isPlaying) {
        //         VoiceLineSource.clip = toPlay;
        //         VoiceLineSource.Play();
        //         toPlay = null;
        //     } 
        // }

        if (queue.Count > 0) {
            if (!VoiceLineSource.isPlaying) {
                
                VoiceLineSource.clip = queue[0].voiceLine;

                VoiceLineSource.Play();
                subtitleSource.text = queue[0].subtitle;

                if (queue[0].duration > 0) {
                    subtitleClearDelay = queue[0].duration;
                } else {
                    subtitleClearDelay = queue[0].voiceLine != null ? queue[0].voiceLine.length + 1.5f : queue[0].subtitle.Length / 8f;
                }

                queue.RemoveAt(0);
            }
        }

        if (subtitleClearDelay > 0) {
            subtitleClearDelay -= Time.deltaTime;
        } else {
            subtitleSource.text = "";
        }

    }

}
