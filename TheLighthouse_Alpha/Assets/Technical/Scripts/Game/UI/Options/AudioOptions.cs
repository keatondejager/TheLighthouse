using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class AudioOptions : MonoBehaviour
{

    public List<VolumeSetting> settings;
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

    public float sensitivity = 0.2f;
    private float delay;


    private bool isRightDown;
    private bool isLeftDown;
    
    private void Awake() {
        controls = new PlayerInputActions();

        controls.OptionsMenu.Back.canceled += ctx => Revert();

        controls.OptionsMenu.Up.started += ctx => Up();
        controls.OptionsMenu.Down.started += ctx => Down();

        controls.OptionsMenu.Left.started += ctx => Left();
        controls.OptionsMenu.Left.performed += ctx => isLeftDown = true;
        controls.OptionsMenu.Left.canceled += ctx => isLeftDown = false;
        
        controls.OptionsMenu.Right.started += ctx => Right();
        controls.OptionsMenu.Right.performed += ctx => isRightDown = true;
        controls.OptionsMenu.Right.canceled += ctx => isRightDown = false;

        controls.OptionsMenu.Save.canceled += ctx => Save();

        controls.OptionsMenu.Defaults.started += ctx => SetDefault();
    }

    private void Update() {
        if (isRightDown) {
            Right();
        } 
        if (isLeftDown) {
            Left();
        }
    }

    public void Save () {
        foreach(VolumeSetting item in settings) {
            item.SaveVolume();
        }
    }

    public void Revert () {
        foreach (VolumeSetting item in settings) {
            item.RevertVolume();
        }
    }

    public void SetDefault () {
        foreach (VolumeSetting item in settings) {
            item.SetToDefault();
        }
    }


    private void OnEnable() {
        controls.OptionsMenu.Enable();
        controls.UINavigation.Disable();

        foreach (VolumeSetting item in settings) {
            item.FetchVolume();
            item.display.text = item.volume.ToString();
        }
        optionIndex = 0;
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
        if (delay < Time.time) {
            settings[optionIndex].volume = Mathf.Clamp( settings[optionIndex].volume - 1, 0, 100);
            delay = Time.time + sensitivity;
        }
    }

    private void Right () {
        if (delay < Time.time) {
            settings[optionIndex].volume = Mathf.Clamp( settings[optionIndex].volume + 1, 0, 100);
            delay = Time.time + sensitivity;
        }
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
            manager.SetFloat(volumeParameter, _volume);
        }
    }

    private float _volume; 

    public float DefaultVolume;
    private float originalVolume;
    public GameObject indicator;
    public AudioMixer manager;

    public string volumeParameter = "Master Volume";

    public void FetchVolume () {
        manager.GetFloat(volumeParameter, out originalVolume);
        _volume = originalVolume;
    }

    public void SaveVolume() {
        manager.SetFloat(volumeParameter, _volume);
        originalVolume = _volume;
    }

    public void RevertVolume () {
        manager.SetFloat(volumeParameter, originalVolume);
        _volume = originalVolume;
        display.text = volume.ToString();
    }

    public void SetToDefault () {
        originalVolume = DefaultVolume;
        RevertVolume();
    }

} 
