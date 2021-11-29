using System.Collections;
using System.Collections.Generic;
using Unity.Audio;
using UnityEngine;
using System;
using Fungus;

public class CharacterRandomTalk : MonoBehaviour
{
    public Character character;

    public Canvas sayDialog;
    
    public Sound[] sounds;

    float master = 0f;
    float volume = 0f;
    float pitch = 0f;

    string clip = "";

    [HideInInspector]
    public Sound s = null;

    public AudioSettings settings;

    public float timer = 1f;
    public float timerReset = 1f;

    void Awake()
    {
        UpdateLocalValues();

        foreach (Sound sound in sounds) // sets source sounds variables
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;

            sound.source.volume = volume * master;
            sound.source.pitch = pitch;
        }
    }

    public void Update()
    {
        timer = timer - Time.deltaTime;

        if (timer <= 0 && sayDialog.gameObject.activeInHierarchy) 
        {
            int vowelNum = UnityEngine.Random.Range(5, Enum.GetNames(typeof(SoundNames)).Length);

            s = Array.Find(sounds, sound => sound.name.ToString() == Enum.GetName(typeof(SoundNames), vowelNum));

            if (s.clip == sayDialog.GetComponent<AudioSource>().clip)
                return;

            timer = timerReset;

            sayDialog.GetComponent<AudioSource>().clip = s.clip;
            sayDialog.GetComponent<AudioSource>().loop = false;
            sayDialog.GetComponent<AudioSource>().Play();
        }
    }

    public void UpdateLocalValues()
    {
        master = settings.master;
        volume = settings.volume;
        pitch = settings.pitch;
        clip = settings.clip.ToString();
    }
}
