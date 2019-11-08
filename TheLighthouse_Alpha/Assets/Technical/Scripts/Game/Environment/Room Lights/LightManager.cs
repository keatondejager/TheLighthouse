using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{

    public List<GameObject> SceneLights;
    public List<GameObject> LightsToTurnOff;


    public int LightsOffNarrativeIndex;
    public void TurnLightsOn () {
        LightsToTurnOff = new List<GameObject>();
        foreach (GameObject light in SceneLights) {
            light.SetActive(true);
        }
        StartCoroutine(LightsOff());

    }

    IEnumerator LightsOff() {
        yield return new WaitForSeconds(1.5f);
        NarrativeController.instance.TriggerNarrative(LightsOffNarrativeIndex);
        foreach (GameObject item in LightsToTurnOff) {
            item.SetActive(false);
            yield return new WaitForSeconds(Random.Range(0f, 0.1f));
        }
    }
}
