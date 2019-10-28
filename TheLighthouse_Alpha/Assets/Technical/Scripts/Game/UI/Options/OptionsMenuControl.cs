﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenuControl : MonoBehaviour
{
    public List<GameObject> optionsLists;
    public List<Transform> optionLabels;
    public GameObject MainMenu;

    

    public GameObject MenuIndicator;

    private int _listIndex;
    protected int index {
        get => _listIndex;
        set {
            optionsLists[_listIndex].SetActive(false);

            _listIndex = value;
            if (_listIndex < 0) {
                _listIndex = optionsLists.Count - 1;
            }

            if (_listIndex >= optionsLists.Count) {
                _listIndex = 0;
            }
            optionsLists[_listIndex].SetActive(true);
            Vector3 position = MenuIndicator.transform.position;
            position.x = optionLabels[_listIndex].position.x;
            MenuIndicator.transform.position = position;
        }
    }

    private PlayerInputActions controls;

    private void Awake() {
        controls = new PlayerInputActions();

        controls.OptionsMenu.Next.started += ctx => index++;
        controls.OptionsMenu.Previous.started += ctx => index--;

        controls.OptionsMenu.Back.canceled += ctx => CloseMenu();
        controls.OptionsMenu.Save.performed += ctx => CloseMenu();
    }

    private void OnEnable() {
        controls.OptionsMenu.Enable();
        index = 0;
    }

    private void OnDisable() {
        controls.OptionsMenu.Disable();
    }

    private void CloseMenu () {
        MainMenu.SetActive(true);
        this.gameObject.SetActive(false);
    }
}