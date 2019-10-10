using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class Valve_Puzzle : MonoBehaviour
{   
    [SerializeField] protected GameObject ButtonPrompt;
    [Space]

    [SerializeField] protected ParticleSystem steam;
    [SerializeField] protected GameObject steamCollider;
    private PlayerManager manager;
    private bool hasFunction;
    private void OnTriggerEnter(Collider other) {
        if (steam.isStopped) {
            return;
        }
        var obj = other.GetComponent<PlayerManager>();
        if (obj is PlayerManager) {
            if (!manager) {
                manager = obj;
            }
            if (!hasFunction) {
                manager.OnInteractEnter += Interact;
                hasFunction = true;
            }
            ButtonPrompt.SetActive(hasFunction);
        }
    }

    private void OnTriggerExit(Collider other) {
        var obj = other.GetComponent<PlayerManager>();
        if (obj is PlayerManager) {
            if (!manager) {
                manager = obj;
            }
            if (hasFunction) {
                manager.OnInteractEnter -= Interact;
                hasFunction = false;
            }
            ButtonPrompt.SetActive(hasFunction);
        }
    }

    private void Interact () {
        steam.Stop();
        steamCollider.SetActive(false);
        ButtonPrompt.SetActive(false);
    }   
}
