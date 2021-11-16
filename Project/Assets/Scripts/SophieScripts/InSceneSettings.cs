using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InSceneSettings : MonoBehaviour
{
    public bool getInfo = false;

    [Range(0f, 1f)]
    public float masterVolume = 0f;

    [Range(0f, 1f)]
    public float volume = 0f;

    [Range(.1f, 3f)]
    public float pitch = 0f;

    public float audioTime = 0f;
    public string clip = "";

    public AudioManager manager;

    public void GetSettings()
    {
        if (getInfo)
        {
            masterVolume = PlayerPrefs.GetFloat(AudioKeys.MASTER.ToString(), 0.5f);
            volume = PlayerPrefs.GetFloat(AudioKeys.VOLUME.ToString(), 0.5f);
            pitch = PlayerPrefs.GetFloat(AudioKeys.PITCH.ToString(), 1f);
            audioTime = PlayerPrefs.GetFloat(AudioKeys.TIME.ToString(), 0f);
            clip = PlayerPrefs.GetString(AudioKeys.CLIP.ToString());

            SaveSettings();
        }
    }

    public void SaveSettings() // set inputs on button click/changing scenes, when change settings, on game launch
    {
        foreach (Sound s in manager.sounds)
        {
            if (s.source.isPlaying)
            {
                audioTime = s.source.time;
                clip = s.source.clip.name;
                return;
            }
        }

        PlayerPrefs.SetFloat(AudioKeys.MASTER.ToString(), masterVolume);
        PlayerPrefs.SetFloat(AudioKeys.VOLUME.ToString(), volume);
        PlayerPrefs.SetFloat(AudioKeys.PITCH.ToString(), pitch);
        PlayerPrefs.SetFloat(AudioKeys.TIME.ToString(), audioTime);
        PlayerPrefs.SetString(AudioKeys.CLIP.ToString(), clip);
        PlayerPrefs.Save();
    }
}
