using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class LanternPickUp : MonoBehaviour
{
    [Header("Reference")]
        [SerializeField] protected PlayerManager manager;
        [SerializeField] protected GameObject buttonPrompt;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            buttonPrompt.SetActive(true);
            manager.OnInteractEnter += PickUp;
            manager.isLantern = true;
        }
    }


    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            buttonPrompt.SetActive(false);
            manager.OnInteractEnter -= PickUp;
            manager.isLantern = false;
        }
    }

    public void PickUp () {
        manager.OnInteractEnter -= PickUp;
        this.gameObject.SetActive(false);
    }
}
