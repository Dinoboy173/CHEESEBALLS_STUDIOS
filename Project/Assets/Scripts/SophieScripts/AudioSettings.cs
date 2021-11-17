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

        manager.StartUp();
        manager.UpdateLocalValues();
        manager.Play(clip.ToString());
    }

    public void GetValues()
    {
        string sClip = "";
        string defaultClip = SoundNames.MainTheme.ToString();

        master = PlayerPrefs.GetFloat(AudioKeys.MASTERVOLUME.ToString(), master);
        volume = PlayerPrefs.GetFloat(AudioKeys.VOLUME.ToString(), volume);
        pitch = PlayerPrefs.GetFloat(AudioKeys.PITCH.ToString(), pitch);
        sClip = PlayerPrefs.GetString(AudioKeys.CLIP.ToString(), defaultClip);
        time = PlayerPrefs.GetFloat(AudioKeys.TIME.ToString(), time);

        if      (sClip == SoundNames.MainTheme.ToString())      clip = SoundNames.MainTheme;
        else if (sClip == SoundNames.BeachTheme.ToString())     clip = SoundNames.BeachTheme;
        else if (sClip == SoundNames.CaveTheme.ToString())      clip = SoundNames.CaveTheme;
        else if (sClip == SoundNames.MansionTheme.ToString())   clip = SoundNames.MansionTheme;
    }

    public void SetValues()
    {
        time = manager.s.source.time;

        PlayerPrefs.SetFloat(AudioKeys.MASTERVOLUME.ToString(), master);
        PlayerPrefs.SetFloat(AudioKeys.VOLUME.ToString(), volume);
        PlayerPrefs.SetFloat(AudioKeys.PITCH.ToString(), pitch);
        PlayerPrefs.SetString(AudioKeys.CLIP.ToString(), clip.ToString());
        PlayerPrefs.SetFloat(AudioKeys.TIME.ToString(), time);
        PlayerPrefs.Save();
    }
}