using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

[RequireComponent(typeof(ParticleSystem), typeof(BoxCollider))]
public class Gas_Puzzle : MonoBehaviour
{
    [Header("References")]
        public CinemachineVirtualCamera mainCam;
        [SerializeField] private bool isPlayerInRange;
        [SerializeField] protected BoxCollider myCollider;
        [SerializeField] protected ParticleSystem myParticles;
        [SerializeField] protected Image breathMeter;
        [SerializeField] protected Image breathBackground;

    [Header("Control Variables")]
        [SerializeField] protected float _breathDecayRate;
        [SerializeField] protected float _breathRecoveryRate;
        public float breathDecayRate {
            get {
                return _breathDecayRate / 100f;
            }
        }
        public float breathRecoveryRate {
            get {
                return _breathRecoveryRate / 100f;
            }
        }
        [Range(0f, 1f)] private float breathAmount;
        [Range(0, 15f)][SerializeField] protected float secondsToRemoveMeter;

        [SerializeField] protected float normalCameraFocal = 40;
        [SerializeField] protected float minimumCameraFocal = 20;


    
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            isPlayerInRange = true;

            StopCoroutine(DisableBreathMeter());

            Color opaqueColor = breathMeter.color;
            opaqueColor.a = 1;
            breathMeter.color = opaqueColor;

            opaqueColor = Color.white;
            opaqueColor.a = 1;
            breathBackground.color = opaqueColor;
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            isPlayerInRange = false;
            StartCoroutine(DisableBreathMeter());
        }
    }

    private void Update() {
        if (isPlayerInRange) {
            breathAmount = Mathf.Lerp(breathAmount, 0f, breathDecayRate * Time.deltaTime);
            mainCam.m_Lens.FieldOfView = Mathf.Lerp(mainCam.m_Lens.FieldOfView, minimumCameraFocal, breathDecayRate * Time.deltaTime);
            StopAllCoroutines();
        } else {
            breathAmount = Mathf.Lerp(breathAmount, 1f, breathRecoveryRate * Time.deltaTime);
            mainCam.m_Lens.FieldOfView = Mathf.Lerp(mainCam.m_Lens.FieldOfView, normalCameraFocal, breathRecoveryRate * Time.deltaTime);
        }

        breathMeter.fillAmount = breathAmount;
    }

    IEnumerator DisableBreathMeter () {
        yield return new WaitForSeconds(secondsToRemoveMeter);
        Color transparentColor = breathMeter.color;
        transparentColor.a = 0;
        for (int i = 0; i < 100; i++) {
            breathMeter.color = Color.Lerp(breathMeter.color, transparentColor, Time.deltaTime);
            breathBackground.color = Color.Lerp(breathBackground.color, transparentColor, Time.deltaTime);
            yield return new WaitForEndOfFrame();
        }
        breathBackground.color = transparentColor;
        breathMeter.color = transparentColor;
    }
}
