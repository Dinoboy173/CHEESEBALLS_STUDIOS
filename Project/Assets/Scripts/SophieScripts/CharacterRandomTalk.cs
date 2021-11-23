using System.Collections;
using System.Collections.Generic;
using Unity.Audio;
using UnityEngine;
using System;
using Fungus;

public class CharacterRandomTalk : MonoBehaviour
{
    public Character character;
    
    public Sound[] sounds;

    float master = 0f;
    float volume = 0f;
    float pitch = 0f;

    string clip = "";

    [HideInInspector]
    public Sound s = null;

    public AudioSettings settings;

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

    public void FixedUpdate()
    {
        int vowelNum = UnityEngine.Random.Range(0, 5); 

        Debug.Log("Vowel " + (int)SoundNames.VowelA);
        Debug.Log("Random Num " + vowelNum);
        
        // s = Array.Find(sounds, sound => sound.name == vowelNum);

        character.soundEffect = s.clip;
    }

    public void UpdateLocalValues()
    {
        master = settings.master;
        volume = settings.volume;
        pitch = settings.pitch;
        clip = settings.clip.ToString();
    }
}
