using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISpriteSheetAnimation : MonoBehaviour
{
    [Header("Sprite and Image Reference")]
        [SerializeField] protected List<Sprite> frames;
        [SerializeField] protected Image image;

        [SerializeField] protected int framesPerSprite = 5;

        private int index = 0;
        private int frameCount = 0;
    private void OnEnable() {
        AnimationController.instance.OnAnimationCycle += Animate;
    } 

    private void Animate() {
        if (frames.Count == 0) {
            return;
        }
        frameCount++;
        if (frameCount == framesPerSprite) {
            index++;
            if (index >= frames.Count) {
                index = 0;
            }
            image.sprite = frames[index];
            frameCount = 0;
        }
    }

    private void OnDisable() {
        AnimationController.instance.OnAnimationCycle -= Animate;
    }





}
