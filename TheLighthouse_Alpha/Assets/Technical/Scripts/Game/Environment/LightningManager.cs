using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningManager : MonoBehaviour
{

    public List<Light> AreaLights = new List<Light>();
    public ParticleSystem LightningParticleSystem;

    public float minTriggerTime = 0.75f;
    public float maxTriggerTime = 1f;

    private float selectedTriggerTime = 0f;
    private float timer = 0f;

    private void Start()
    {
        selectedTriggerTime = Random.Range(minTriggerTime, maxTriggerTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= selectedTriggerTime)
        {
            LightningParticleSystem.Play();
            foreach (Light AreaLight in AreaLights)
            {
                AreaLight.enabled = true;
            }
            timer = 0f;
            selectedTriggerTime = Random.Range(minTriggerTime, maxTriggerTime);
        }

        if (LightningParticleSystem.isStopped)
        {
            foreach (Light AreaLight in AreaLights)
            {
                AreaLight.enabled = false;
            }
            timer += Time.deltaTime;
        }
    }
}
