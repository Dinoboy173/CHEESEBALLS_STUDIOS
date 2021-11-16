using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public PlayMusic playMusic;
    public InSceneSettings settings;

    public Sound[] sounds;

    Sound s = null;

    [HideInInspector]
    public float time = 0f;

    float masterVolume = 0f;
    float volume = 0f;
    float pitch = 0f;

    void Awake()
    {
        settings.GetSettings();
        masterVolume = settings.masterVolume;
        volume = settings.volume;
        pitch = settings.pitch;

        foreach (Sound s in sounds) // sets source sounds variables
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = volume * masterVolume;
            s.source.pitch = pitch;
        }

        // playMusic.Play();
    }

    public void Play(string name)
    {
        s = Array.Find(sounds, sound => sound.name == name); // gets specific sound from array

        s.source.Play(); // plays sound
        s.source.time = time;
    }

    public void Stop()
    {
        s.source.Stop(); // stops sound
    }

    public void SetSettings()
    {
        masterVolume = settings.masterVolume;
        volume = settings.volume;
        pitch = settings.pitch;

        s.source.volume = volume * masterVolume;
        s.source.pitch =  pitch;
    }
}
