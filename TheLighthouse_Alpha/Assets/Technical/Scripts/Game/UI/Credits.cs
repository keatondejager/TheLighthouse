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

            for (int i = 0; i < 15; i++) {
                item.display.color = Color.Lerp(item.display.color, opaque, 0.15f );
                yield return new WaitForEndOfFrame();
            }
            
            
            yield return new WaitForSecondsRealtime(item.delay);
            int iterations = item.RussianTitle.Length > item.EnglishTitle.Length ? item.EnglishTitle.Length : item.RussianTitle.Length;
            for (int i = 0; i < iterations; i++) {
                item.display.text = item.display.text.Remove(i, 1);
                item.display.text = item.display.text.Insert(i, item.EnglishTitle[i].ToString());
                yield return new WaitForSecondsRealtime(0.05f);
            }

            item.display.text = item.EnglishTitle;
            yield return new WaitForSecondsRealtime(item.duration * 0.7f);

            
            for (int i = 0; i < 15; i++) {
                item.display.color = Color.Lerp(item.display.color, transparent, 0.1f );
                yield return new WaitForEndOfFrame();
            }

            item.display.gameObject.SetActive(false);
            yield return null;
        }
        //SceneManager.LoadScene(0);
    }
    

    private void OnDisable() {
        controls.PuzzleControls.Disable();
    }

}

[System.Serializable]
public class Credit {
    public string RussianTitle;
    public string EnglishTitle;
    public List<string> RussianNames;
    public List<string> EnglishNames;

    public float delay;
    public float duration;

    public TMP_Text display;
}
