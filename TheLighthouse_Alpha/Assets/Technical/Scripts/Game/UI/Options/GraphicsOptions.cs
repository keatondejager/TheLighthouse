using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;
using UnityEngine.Experimental.Rendering.HDPipeline;
using TMPro;


public class GraphicsOptions : MonoBehaviour
{
    [Header("Brightness Settings")]
        public float BrightnessValue;
        public VolumeProfile menuVolume;
        public VolumeProfile gameSceneVolume;

        public Slider valueDisplay;
        [Space]
        public float minExposure;
        public float maxExposure;
        public float defaultExposure;
        [Space]
        public float increment = 0.1f;
    
    [Header("Reference")]
        public List<GameObject> indicators;

        private int _optionIndex;
        protected int index {
            get => _optionIndex;
            set {
                indicators[_optionIndex].SetActive(false);
                _optionIndex = value;
                if (_optionIndex < 0) {
                    _optionIndex = indicators.Count - 1;
                } 

                if (_optionIndex >= indicators.Count) {
                    _optionIndex = 0;
                }
                indicators[_optionIndex].SetActive(true);
            }
        }

        public float sensitivity = 0.2f;
    private float delay;

    private Exposure menuExposure;
    private Exposure gameSceneExposure;

    private PlayerInputActions controls;
    
    private bool isRightDown;
    private bool isLeftDown;

    private void Awake() {
        controls = new PlayerInputActions();

        controls.OptionsMenu.Left.performed += ctx => isLeftDown = true;
        controls.OptionsMenu.Left.canceled += ctx => isLeftDown = false;

        controls.OptionsMenu.Right.performed += ctx => isRightDown = true;
        controls.OptionsMenu.Right.canceled += ctx => isRightDown = false;

        controls.OptionsMenu.Up.started += ctx => index--;
        controls.OptionsMenu.Down.started += ctx => index++;
    }
    
    // Start is called before the first frame update
    void Start()
    {   
        Exposure temp;
        if (menuVolume.TryGet<Exposure>(out temp)) {
            menuExposure = temp;
        }

        if (gameSceneVolume.TryGet<Exposure>(out temp)) {
            gameSceneExposure = temp;
        }

        BrightnessValue = menuExposure.compensation.GetValue<float>();
    }

    private void Update() {
        if (isLeftDown) {
            Left();
        }
        if (isRightDown) {
            Right();
        }
    }


    private void OnEnable() {
        valueDisplay.value = Map01(BrightnessValue, minExposure, maxExposure);
        controls.OptionsMenu.Enable();
    }

    private void OnDisable() {
        controls.OptionsMenu.Disable();
    }


    public void Right () {
        if (Time.time < delay) {
            return;
        }

        if (index == 0) {
            BrightnessValue = Mathf.Clamp(BrightnessValue + increment, minExposure, maxExposure);
            SetExposure(); 
        }

        delay = Time.time + sensitivity;
    }

    public void Left () {
        if (Time.time < delay) {
            return;
        }

        if (index == 0) {
            BrightnessValue = Mathf.Clamp(BrightnessValue - increment, minExposure, maxExposure);
            SetExposure();
        }

        delay = Time.time + sensitivity;
    }

    private void SetExposure () {
        menuExposure.compensation.value = BrightnessValue; 
        gameSceneExposure.compensation.value = BrightnessValue;

        valueDisplay.value = Map01(BrightnessValue, minExposure, maxExposure);
    } 

    private float Map01 (float val, float min, float max) {
        return (val - min) / (max - min); 
    } 

}
