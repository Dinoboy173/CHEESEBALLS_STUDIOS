using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    [HideInInspector]
    public Sound s = null;

    float master = 0f;
    float volume = 0f;
    float pitch = 0f;

    string clip = "";
    float time = 0f;

    public AudioSettings settings;
    public AudioMixerGroup audioMixer;

    public void StartUp()
    {
        UpdateLocalValues();
        int i = 0;
        foreach (Sound sound in sounds) // sets source sounds variables
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;

            sound.source.volume = volume * master;
            sound.source.pitch = pitch;
            sound.source.outputAudioMixerGroup = audioMixer;
            if(i < 4)
            {
                sound.source.loop = true;
            }
            i++;
        }
    }

    public void Play(string name)
    {
        s = Array.Find(sounds, sound => sound.name.ToString() == name); // gets specific sound from array

        s.source.time = time;
        s.source.Play(); // plays sound
    }

    public void Stop()
    {
        s.source.Stop(); // stops sound
    }

    public void UpdateLocalValues()
    {
        master = settings.master;
        volume = settings.volume;
        pitch = settings.pitch;
        clip = settings.clip.ToString();
        time = settings.time;
    }
}
