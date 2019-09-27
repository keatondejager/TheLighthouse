using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]
public class BetterBtn : MonoBehaviour
{
    [Header("States")]
        public Color Normal;
        public Color Highlighted;
        public Color Pressed;

    [Header("Reference")]
        [SerializeField] protected Image btnSprite;
        [SerializeField] protected TMP_Text btnText;

    [Header("Events")]
        [Space]
        public UnityEvent btnSubmit;

    public void Activate () {
        if (!btnSprite) {
            btnSprite = GetComponent<Image>();
        }
        btnSprite.color = Highlighted;
    }

    public void Deactivate () {
        if (!btnSprite) {
            btnSprite = GetComponent<Image>();
        }
        btnSprite.color = Normal;
    }

    public void Submit () {
        btnSprite.color = Pressed;

        if (btnSubmit != null) {
            btnSubmit.Invoke();
        }
    }
}
