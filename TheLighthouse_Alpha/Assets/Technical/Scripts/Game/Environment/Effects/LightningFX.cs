using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningFX : MonoBehaviour
{
    [Header("Reference Objects")]
    [SerializeField] protected List<Light> effectLights;
    [SerializeField] protected ParticleSystem particles;

    [Header("Interval Control")]
    [Range(0f, 15f)] [SerializeField] protected float minimumInterval = 5f;
    [Range(1f, 60f)] [SerializeField] protected float interval = 20f;
    [Range(0f, 1f)] [SerializeField] protected float regularity = 0.2f; 
    
    [Header("Light Controls")]
    [SerializeField] protected float lightOnTime = 0.2f;
    [SerializeField] protected int lightFlickerCount = 1;
    
    [Header("Debugging")]
    [SerializeField] private float nextAttempt = 0;
    private bool canCount = true;

    private void FixedUpdate() {
        if (canCount) {
            nextAttempt -= Time.fixedDeltaTime;
            if (nextAttempt <= 0) {
                LightningEffect();
            }
        }
    }

    public void LightningEffect () {
        float chance = Random.Range(0f, 1f);
        if (chance < regularity) {
            particles.Play();
            StartCoroutine(LightEffect());
            AudioManager.instance.PlayThunder();
            canCount = false;
        }
        StartCoroutine(LightningCooldown());
    }

    IEnumerator LightningCooldown() {
        canCount = false;

        yield return new WaitForSeconds(minimumInterval);

        float ratio = (1 - regularity) * interval; 
        nextAttempt = Random.Range(ratio, interval);

        canCount = true;
    }


    IEnumerator LightEffect () {
        for (int i = 0; i < lightFlickerCount; i ++) {
            foreach (Light item in effectLights) {
                item.gameObject.SetActive(true);
            }
            yield return new WaitForSecondsRealtime( lightOnTime );

            foreach (Light item in effectLights) {
                item.gameObject.SetActive(false);
            }
            yield return new WaitForSecondsRealtime( lightOnTime / Random.Range(1f, 5f));
        }
    }
}
