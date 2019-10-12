using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

    public static AnimationController instance;

    public delegate void AniamtionLoop();
    public event AniamtionLoop OnAnimationCycle;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this){
            Destroy(this.gameObject);
        }
    }

    private void FixedUpdate() {
        if (OnAnimationCycle != null) {
            OnAnimationCycle();   
        }
    }

}
