using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour
{
    public bool getSettings = false;

    [Range(0f, 1f)]     public float master = 0f;
    [Range(0f, 1f)]     public float volume = 0f;
    [Range(0.1f, 3f)]   public float pitch = 0.1f;

    public SoundNames clip;
    public float time = 0f;
    
    public AudioManager manager;

    void Awake()
    {
        if (getSettings)
            GetValues();

        manager.StarttUp();
        manager.UpdateLocalValues();
        manager.Play(clip.ToString());
    }

    public void GetValues()
    {
        PlayerPrefs.GetFloat(AudioKeys.MASTERVOLUME.ToString(), master);
        PlayerPrefs.GetFloat(AudioKeys.VOLUME.ToString(), volume);
        PlayerPrefs.GetFloat(AudioKeys.PITCH.ToString(), pitch);
        PlayerPrefs.GetString(AudioKeys.CLIP.ToString(), clip.ToString());
        PlayerPrefs.GetFloat(AudioKeys.TIME.ToString(), time);
    }

    public void SetValues()
    {
        time = manager.s.source.time;

        PlayerPrefs.SetFloat(AudioKeys.MASTERVOLUME.ToString(), master);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat(AudioKeys.VOLUME.ToString(), volume);
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat(AudioKeys.PITCH.ToString(), pitch);
        PlayerPrefs.Save();
        PlayerPrefs.SetString(AudioKeys.CLIP.ToString(), clip.ToString());
        PlayerPrefs.Save();
        PlayerPrefs.SetFloat(AudioKeys.TIME.ToString(), time);
        PlayerPrefs.Save();
    }
}