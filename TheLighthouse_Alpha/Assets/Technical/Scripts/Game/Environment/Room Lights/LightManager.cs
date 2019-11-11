using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{

    public List<GameObject> SceneLights;
    public List<GameObject> LightsToTurnOff;

    public AudioSource lightSoundEffect;
    public AudioSource steamSoundSource;

    public float voiceLineLength;

    public float audioClipDuration;
    public int LightsOffNarrativeIndex;
    public void TurnLightsOn () {
        foreach (GameObject light in SceneLights) {
            light.SetActive(true);
        }
        StartCoroutine(LightsOff());

    }

    IEnumerator LightsOff() {
        yield return new WaitForSecondsRealtime(voiceLineLength);
        lightSoundEffect.Play();
        yield return new WaitForSeconds(audioClipDuration);
        AudioManager.instance.SetSteamSound();
        //NarrativeController.instance.TriggerNarrative(LightsOffNarrativeIndex);
        foreach (GameObject item in LightsToTurnOff) {
            item.SetActive(false);
        }

    }
}
