using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(Image))]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(EventTrigger))]
public class BetterButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
    [Header("Transitions")]
        public bool ColorTransition;
        public bool SizeTransition;
        public bool SpriteTransition;
        public bool TextTransition;
        public bool AudioAnimation;

    [Header("Color Transitions")]
        public Color NormalColor;
        public Color HighlightedColor;
        public Color PressedColor;
        public bool AnimateText;

    [Header("Size Transitions")]
        public Vector3 StartScale;
        public Vector3 HighlightedScale;
        public Vector3 PressedScale;

    [Header("Sprite Transitions")]
        public Sprite NormalSprite;
        public Sprite HighlightedSprite;
        public Sprite PressedSprite;
    
    [Header("Text Transitions")]
        public string StartText;
        public string StandardText;
        public string HighlightedText;
        public string PressedText;
        public float AnimationDelay;
    
    [Header("Audio Animations")]
        public AudioSource source;

    
    [Header("Control / Reference")]
        public EventSystem Master;
        public TMP_Text TextObject;
        private Image MainImage;    
        private int numTextIterations;
        private string TextHolder;
        private bool active = false;
        
    private void Awake() {
        MainImage = GetComponent<Image>();
    }
    private void Start() {   
        if (active) {
            return;
        }
        if (SizeTransition) {
            transform.localScale = StartScale;
        }

        if (SpriteTransition) {
            MainImage.sprite = NormalSprite;
        }

        if (ColorTransition){
            MainImage.color = NormalColor;
        }

        if (TextTransition) {
            TextObject.text = StartText;
            numTextIterations = 0;
            TextHolder = StartText;
            for (int i = 0; i < StartText.Length; i++){
                if (i >= StandardText.Length) {
                    StandardText += (char)(0);
                }
                numTextIterations += Mathf.Abs((int)StandardText[i] - (int)StartText[i]);
            }
            StartCoroutine(AnimateTextRoutine());
        } else {
            TextObject.text = StandardText;
        }
    }

    private IEnumerator AnimateTextRoutine () {
        int delta = 0;
        char letter;
        int direction = 1;

        yield return new WaitForSecondsRealtime(AnimationDelay);

        for (int i = 0; i < StandardText.Length; i++){
            if ((int)TextHolder[i] < (int)StandardText[i]){
                direction = 1;
                delta = (int)StandardText[i] - (int)TextHolder[i]; 
            } else if ((int)TextHolder[i] > (int)StandardText[i]){
                direction = -1;
                delta = (int)TextHolder[i] - (int)StandardText[i]; 
            } else {
                delta = 0;
                continue;
            }

            for (int j = 0; j < delta; j++){
                letter = (char) ( (int)TextHolder[i] + direction);
                TextHolder = TextHolder.Remove(i, 1);
                TextHolder = TextHolder.Insert(i, letter.ToString());
                TextObject.text = TextHolder;
                yield return new WaitForSeconds(1f / numTextIterations);
            }

            
        }
        
    }

    public void OnPointerEnter(PointerEventData data){
        Activate();
    }

    public void Activate () {
        active = true;
        Master.SetSelectedGameObject(this.gameObject);
        if (SizeTransition) {
            transform.localScale = HighlightedScale;
        }

        if (SpriteTransition) {
            MainImage.sprite = HighlightedSprite;
        }

        if (AudioAnimation) {
            if (source.isPlaying) {
                source.Stop();
            }
            source.Play();
        }

        if (ColorTransition){
            if (!MainImage) {
                MainImage = GetComponent<Image>();
            }
            MainImage.color = HighlightedColor;
        }
    }

    public void OnPointerExit(PointerEventData data){
        Deactivate();
    }

    public void Deactivate() {
        active = false;
        if (SizeTransition) {
            transform.localScale = StartScale;
        }

        if (SpriteTransition) {
            MainImage.sprite = NormalSprite;
        }

        if (ColorTransition){
            MainImage.color = NormalColor;
        }
    }

    public void OnPointerDown (PointerEventData data) {
       
        if (SizeTransition) {
            transform.localScale = PressedScale;
        }

        if (SpriteTransition) {
            MainImage.sprite = PressedSprite;
        }

         if (ColorTransition){
            MainImage.color = PressedColor;
        }

    }

    public void OnPointerUp (PointerEventData data) {
        

        if (SizeTransition) {
            transform.localScale = HighlightedScale;
        }

        if (SpriteTransition) {
            MainImage.sprite = HighlightedSprite;
        }

        if (ColorTransition){
            MainImage.color = HighlightedColor;
        }
    }

    
}
