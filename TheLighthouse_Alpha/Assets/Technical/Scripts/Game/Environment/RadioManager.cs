using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Player;

public class RadioManager : MonoBehaviour
{

    public GameObject interactPrompt;
    public AudioSource musicSource;
    private bool hasFunction;
    private void OnTriggerEnter(Collider other) {
        var player = other.GetComponent<PlayerManager>();
        if (player is PlayerManager) {
            interactPrompt.SetActive(true);
            if (!hasFunction) {
                hasFunction = true;
                player.OnInteractEnter += TogglePlay;
            }
        }
    }

    private void OnTriggerExit(Collider other) {
        var player = other.GetComponent<PlayerManager>();
        if (player is PlayerManager) {
            interactPrompt.SetActive(false);
            if (hasFunction) {
                player.OnInteractEnter -= TogglePlay;
                hasFunction = false;
            }
        }
    }

    public void TogglePlay () {
        if (musicSource.isPlaying) {
            musicSource.Pause();
        } else {
            musicSource.Play();
        }
    }
}
