﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControllerSettings : MonoBehaviour
{

    public static ControllerSettings instance;


    public List<Sprite> InteractSprites;
    public List<Sprite> ExamineSprites;
    public List<Sprite> CloseSprites;
    public List<Sprite> ConfirmSprites;


    public Sprite North;
    public Sprite South;
    public Sprite West;
    public Sprite East;

    public delegate void SetSprite();
    public event SetSprite OnSpriteChange;

    public int ActiveController = 0;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this);
    }


    // Start is called before the first frame update
    void Start() {
        if (SceneManager.GetActiveScene().buildIndex == 1) {
            PlayerPrompts player = GameObject.FindObjectOfType<PlayerPrompts>();

            player.SetController(ActiveController == 0);
        }

        SetControllerType(ActiveController);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetControllerType (int type) {
        ActiveController = Mathf.Clamp(type, 0, InteractSprites.Count - 1);
        North = InteractSprites[ActiveController];
        South = ConfirmSprites[ActiveController];
        West = ExamineSprites[ActiveController];
        East = CloseSprites[ActiveController];

        if (OnSpriteChange != null) {
            OnSpriteChange();
        }
    } 
}