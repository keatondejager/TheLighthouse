using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class OptionsMenu : MonoBehaviour
{

    public List<VolumeSetting> settings;

    public GameObject mainMenu;
    private PlayerInputActions controls;

    private int _index;
    public int optionIndex {
        get => _index;
        set {
            settings[_index].indicator.SetActive(false);
            _index = value;
            if (_index >= settings.Count) {
                _index = 0;
            } 
            if (_index < 0) {
                _index = settings.Count - 1;
            }
            settings[_index].indicator.SetActive(true);
           
        }
    }


    
    
    private void Awake() {
        controls = new PlayerInputActions();

        controls.OptionsMenu.Back.performed += ctx => OptionsClose();

        controls.OptionsMenu.Up.started += ctx => Up();
        controls.OptionsMenu.Down.started += ctx => Down();
        controls.OptionsMenu.Left.started += ctx => Left();
        controls.OptionsMenu.Right.started += ctx => Right();

        controls.OptionsMenu.Save.performed += ctx => Save();
    }

    public void Save () {
        foreach(VolumeSetting item in settings) {
            item.SaveVolume();
        }
        OptionsClose();
    }

    private void OptionsClose () {
        mainMenu.SetActive(true);

        this.gameObject.SetActive(false);
        controls.UINavigation.Enable();
    }

    private void OnEnable() {
        controls.OptionsMenu.Enable();
        controls.UINavigation.Disable();
        mainMenu.SetActive(false);
        foreach (VolumeSetting item in settings) {
            item.FetchVolume();
            item.display.text = item.volume.ToString();
        }
    }

    private void OnDisable() {
        controls.OptionsMenu.Disable();
    }

    private void Up () {
        optionIndex--;
    }

    private void Down () {
        optionIndex++;
    }

    private void Left () {
         settings[optionIndex].volume = Mathf.Clamp( settings[optionIndex].volume - 1, 0, 100);
    }

    private void Right () {
         settings[optionIndex].volume = Mathf.Clamp( settings[optionIndex].volume + 1, 0, 100);
        
    }
}

[System.Serializable]
public class VolumeSetting {
    public TMP_Text display;
    public float volume {
        get {
            return Mathf.Round(_volume + 80f);
        }
        set {
            _volume = Mathf.Round(value - 80f);
            display.text = volume.ToString();
        }
    }

    private float _volume; 
    public GameObject indicator;
    public AudioMixer manager;

    public string volumeParameter = "Master Volume";

    public void FetchVolume () {
        manager.GetFloat(volumeParameter, out _volume);
    }

    public void SaveVolume() {
        manager.SetFloat(volumeParameter, _volume);
    }

} 
