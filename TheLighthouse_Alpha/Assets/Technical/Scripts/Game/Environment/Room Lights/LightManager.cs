using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{

    public List<GameObject> SceneLights;
    public List<GameObject> LightsToTurnOff;

    public float audioClipDuration;
    public int LightsOffNarrativeIndex;
    public void TurnLightsOn () {
        foreach (GameObject light in SceneLights) {
            light.SetActive(true);
        }
        StartCoroutine(LightsOff());

    }

    IEnumerator LightsOff() {
        yield return new WaitForSeconds(audioClipDuration);
        NarrativeController.instance.TriggerNarrative(LightsOffNarrativeIndex);
        foreach (GameObject item in LightsToTurnOff) {
            item.SetActive(false);
        }
    }
}
