using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class GameSettings : MonoBehaviour
{
    public static GameSettings edit;
    private void Awake() {
        if (edit == null) {
            edit = this;
        } else if (edit != this) {
            Destroy(this.gameObject);
        }
    }

    [Header("Audio Settings")]
        public AudioMixer DialogueMaster;
            private float _dialogueVolume;
            public float dialogueVolume {
                get { 
                    return (_dialogueVolume + 80f) / 100f;
                } 
                set {
                    _dialogueVolume = (Mathf.Clamp01(value) * 100f ) - 80f;
                    DialogueMaster.SetFloat("Volume", _dialogueVolume);
                }
            }
        

        public AudioMixer InformativeMixer;
            private float _infromativeSoundVolume;
            public float infromativeSoundVolume {
                get {
                    return (_infromativeSoundVolume + 80f) /100f;
                }
                set {
                    
                    _infromativeSoundVolume = (Mathf.Clamp01(value) * 100f ) - 80f;
                    InformativeMixer.SetFloat("Volume", _infromativeSoundVolume);
                }
            }
        
        public AudioMixer GeneralMixer;
            private float _generalSoundVolume;
            public float generalSoundVolume {
                get {
                    return (_generalSoundVolume + 80f) / 100f;
                }
                set {
                    _generalSoundVolume = (Mathf.Clamp01(value) * 100f ) - 80f;
                    GeneralMixer.SetFloat("Volume", _generalSoundVolume);
                }
            }

        public AudioMixer AmbientMixer;
            private float _ambientVolume;
            public float ambientVolume {
                get {
                    return (_ambientVolume + 80f) / 100f;
                }
                set {
                    _ambientVolume = (Mathf.Clamp01(value) * 100f ) - 80f;
                }
            }

        public AudioMixer MusicMixer;
            private float _musicVolume;
            public float musicVolume {
                get {
                    return (_musicVolume + 80f) / 100f;
                }
                set {
                    _musicVolume = (Mathf.Clamp01(value) * 100f ) - 80f;
                }
            }

    [Header("Graphic Settings")]
        private bool _isFullscreen;
        public bool isFullscreen {
            get {
                _isFullscreen = Screen.fullScreen;
                return _isFullscreen;
            }
            set {
                _isFullscreen = value;
                Screen.fullScreen = _isFullscreen;
            }
        }
        private Resolution[] _resolutions;
        public Resolution[] resolutions {
            get {
                _resolutions = Screen.resolutions;
                return _resolutions;
            }
        }
        private QualitySettings _qualitySettings;

    

   
}
