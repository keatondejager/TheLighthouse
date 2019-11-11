﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private void Awake() {
        if (instance == null) {
            instance = this;
        } else if (instance != this) {
            Destroy(this.gameObject);
        }
    }

    [Header("Spoken Sounds")]
        [SerializeField] protected AudioSource dialogueSource;
        [SerializeField] protected List<AudioClip> dialogue;

    [Header("Interaction Sounds")]
        [SerializeField] protected AudioSource informativeSource;
        [SerializeField] protected List<AudioClip> doors;
        [SerializeField] protected List<AudioClip> inventories;

    [Header("Environement Sounds")]
        [SerializeField] protected AudioSource generalSource;
        [SerializeField] protected List<AudioClip> footsteps;
        [SerializeField] protected List<AudioClip> floorboards;

    [Header("Ambient Sounds")]
        [SerializeField] protected AudioSource rain;
        [SerializeField] protected AudioSource effects;
        [SerializeField] protected List<AudioClip> thunder;

    [Header("Music")]
        [SerializeField] protected AudioSource musicSource;
        [SerializeField] protected List<AudioClip> Songs; 
        [SerializeField] protected AudioClip creditsSong;

    
    [Header("Steam Sound Effects")]
        [SerializeField] protected AudioSource steamSource;
        [SerializeField] protected AudioClip pipeBurst;
        [SerializeField] protected AudioClip steamSound;
        [SerializeField] protected int LightsOffNarrativeIndex;
 

    private void Start() {
        Cursor.visible = false;

        SetMusic();
        SetAmbient();
        SetFootsteps();

        StopSteam();

        if (SceneManager.GetActiveScene().buildIndex == 1) {
            informativeSource.Play();
        }
    }

    private void SetMusic () {
        if (SceneManager.GetActiveScene().buildIndex == 2) {
            rain.Stop();
            musicSource.Stop();

            musicSource.clip = creditsSong;

            musicSource.Play();
            
            Invoke("ExitCredits", creditsSong.length);
            return;
        }

        if (musicSource.isPlaying) {
            musicSource.Stop();
        }

        if (Songs.Count > 0) {
            musicSource.clip = Songs[Mathf.FloorToInt(Random.Range(0, Songs.Count))];
        }

        Invoke("SetMusic", musicSource.clip.length);

        musicSource.Play();
    }


    private void SetFootsteps() {
        if (generalSource.clip == null) {
            generalSource.clip = footsteps[0];
        }
    }

    private void SetAmbient () {
        if (rain.clip == null) {
            return;
        }

        if (!rain.isPlaying) {
            rain.Play();
            rain.loop = true;
        }
    }

    public void PlayThunder () {
        int randomIndex = Mathf.FloorToInt(Random.Range(0, thunder.Count));

        effects.Stop();
        effects.PlayOneShot(thunder[randomIndex]);
    }

    public void StartWalking () {
        if (!generalSource.isPlaying) {
            generalSource.Play();
        }
    }

    public void StopWalking () {
        if (generalSource.isPlaying) {
            generalSource.Pause();
        }
    }

    private void ExitCredits() {
        SceneManager.LoadScene(0);
    }

    public void SetSteamSound () {
        steamSource.clip = pipeBurst;
        steamSource.Play();
        Invoke("SteamEffect", pipeBurst.length-0.1f);
    }

    private void SteamEffect () {
        steamSource.Stop();
        steamSource.clip = steamSound;
        steamSource.loop = true;
        steamSource.Play();
        NarrativeController.instance.TriggerNarrative(LightsOffNarrativeIndex);
    }

    public void StopSteam () {
        steamSource.Stop();
    }

    
}
