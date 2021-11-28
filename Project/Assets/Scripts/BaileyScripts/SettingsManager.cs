using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.EventSystems;

public class SettingsManager : MonoBehaviour
{
    public AudioMixer audioMixer;

    public Dropdown resolutionDropdown;

    Resolution[] resolutions;

    int[] textSpeeds = new int[5] {15,30,60,90,120};
    public int speed = 60;
    public bool autoSkip = false;
    string skip = "false";
    public float setVolume;

    void Start()
    {

        speed = PlayerPrefs.GetInt("TextSpeedSet");
        skip = PlayerPrefs.GetString("AutoSkip");
        setVolume = PlayerPrefs.GetFloat("Volume");



        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            
            if(resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void AutoSkip(bool isSkip)
    {
        autoSkip = isSkip;
        if(autoSkip == false)
        {
            skip = "false";
        }
        else
        {
            skip = "true";
        }
    }

    public void SetVolume(float volume)
    {
        setVolume = volume;
        audioMixer.SetFloat("Volume", setVolume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetTextSpeed(int textSpeed)
    {
       speed = textSpeeds[textSpeed];
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("TextSpeedSet", speed);
        PlayerPrefs.SetString("AutoSkip", skip);
        PlayerPrefs.SetFloat("Volume", setVolume);
    }
}
