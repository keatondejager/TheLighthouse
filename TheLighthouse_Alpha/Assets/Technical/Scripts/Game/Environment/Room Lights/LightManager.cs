using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{

    public List<GameObject> SceneLights;
    public List<GameObject> LightsToTurnOff;

    [Range(0, 1f)] public float breakChance = 0.4f;

    public void TurnLightsOn () {
        LightsToTurnOff = new List<GameObject>();
        foreach (GameObject light in SceneLights) {
            float rand = Random.Range(0f,1f);
            if (rand < 0.45f) {
                LightsToTurnOff.Add(light);
            }
            light.SetActive(true);
        }
        StartCoroutine(LightsOff());

    }

    IEnumerator LightsOff() {
        yield return new WaitForSeconds(1.5f);
        foreach (GameObject item in LightsToTurnOff) {
            item.SetActive(false);
            yield return new WaitForSeconds(Random.Range(0f, 0.1f));
        }
    }
}
