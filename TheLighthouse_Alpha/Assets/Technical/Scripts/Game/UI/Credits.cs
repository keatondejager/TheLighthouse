using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Credits : MonoBehaviour
{

    protected PlayerInputActions controls;

    public List<Credit> credits;

    public Color transparent;
    public Color opaque;
    
    // Start is called before the first frame update
    private void OnEnable() {
        controls = new PlayerInputActions();

        controls.PuzzleControls.Close.performed += ctx => SceneManager.LoadScene(0);
        controls.PuzzleControls.Enable();

        StartCoroutine(RunCredits());

    }

    IEnumerator RunCredits () {
        foreach (Credit item in credits) {
            item.display.gameObject.SetActive(true);
            item.display.text = item.RussianTitle;

            item.display.color = transparent;
            foreach (TMP_Text name in item.names) {
                name.color = transparent;        
            }
            
            for (int i = 0; i < 15; i++) {
                Color lerpColor = Color.Lerp(item.display.color, opaque, 0.15f );
                item.display.color = lerpColor;
                foreach (TMP_Text name in item.names) {
                    name.color = lerpColor;
                }
                yield return new WaitForEndOfFrame();
            }
            
            
            yield return new WaitForSecondsRealtime(item.delay);
            int iterations = item.EnglishTitle.Length;
            for (int i = 0; i < iterations; i++) {
                if (i < item.display.text.Length) {
                    item.display.text = item.display.text.Remove(i, 1);
                    item.display.text = item.display.text.Insert(i, item.EnglishTitle[i].ToString());
                } else {
                    item.display.text += item.EnglishTitle[i];
                }
                yield return new WaitForSecondsRealtime(0.05f);
            }

            item.display.text = item.EnglishTitle;
            yield return new WaitForSecondsRealtime(item.duration * 0.7f);

            
            for (int i = 0; i < 15; i++) {
                Color lerpColor = Color.Lerp(item.display.color, transparent, 0.1f );
                item.display.color = lerpColor;
                foreach (TMP_Text name in item.names) {
                    name.color = lerpColor;
                }
                yield return new WaitForEndOfFrame();
            }

            item.display.gameObject.SetActive(false);
            yield return null;
        }
        SceneManager.LoadScene(0);
    }
    

    private void OnDisable() {
        controls.PuzzleControls.Disable();
    }

}

[System.Serializable]
public class Credit {
    public string EnglishTitle;
    public string RussianTitle;
    
    public List<TMP_Text> names;

    public float delay;
    public float duration;

    public TMP_Text display;
}
