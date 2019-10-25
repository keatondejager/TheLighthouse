using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrompts : MonoBehaviour {

    [Header("Examine")]
        public Sprite Examine_PS4;
        public Sprite Examine_Xbox;
        public SpriteRenderer ExamineRenderer;
    
    [Header("Interact")]
        public Sprite Interact_PS4;
        public Sprite Interact_Xbox;
        public SpriteRenderer InteractRenderer;
    
    [Header("Camera")]
        public Transform cameraTransform;


    public void SetController (bool type) {
        InteractRenderer.sprite = type ? Interact_PS4 : Interact_Xbox;
        ExamineRenderer.sprite = type ? Examine_PS4 : Examine_Xbox;
    } 

    private void Update() {
        InteractRenderer.transform.forward = -cameraTransform.forward;
        ExamineRenderer.transform.forward = -cameraTransform.forward;
    }

}
