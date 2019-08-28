using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NarrativeController : MonoBehaviour
{

    [Header("Reference Objects")]
        [SerializeField] protected TMP_Text _subtitleTrack; 

    [Header("Subtitle Track")]
        [SerializeField] protected List<string> _subtitles;
    
    [Header("Audio Tracks")]
        [SerializeField] protected List<AudioClip> _audioClips;

    [Header("Other Cinematics")]
        [SerializeField] protected List<GameObject> _cinematicControllers;

    [Header("Control Variables")]
        [SerializeField] private List<int> _objectIDs;


    // Start is called before the first frame update
    void Start()
    {
        ClearText();
        _objectIDs = new List<int>();
    }

    private void ClearText () {
        _subtitleTrack.text = "";
    }

    public void StepNarrative (int _objectID, int _narrativeType) {

        if (_objectID < 0) {
            return;
        }
        
        if (_objectIDs.Contains(_objectID)) {
            return;
        }

        _objectIDs.Add(_objectID);

        switch (_narrativeType) {
            case 0:
                _subtitleTrack.text = _subtitles[_objectID]; 
                Invoke("ClearText", _subtitles[_objectID].Length / 10f);
                break;
            case 1:
                Debug.Log("Audio Narrative Cue");
                break;
            case 2: 
                Debug.Log("Cinematic Narrative");
                break;
        }
    }


}
