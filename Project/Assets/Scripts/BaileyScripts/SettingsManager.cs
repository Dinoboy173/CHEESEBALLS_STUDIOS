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
    public Slider audioSlider;
    public Toggle autoSkipToggle;
    public Dropdown textSpeedDropdown;
    public Toggle isFull;
    public Dropdown qualityDropdown;


    Resolution[] resolutions;

    int[] textSpeeds = new int[5] { 15, 30, 60, 90, 120 };
    public int speed = 60;
    int speedLoc = 0;
    public bool autoSkip = false;
    string skip = "false";
    string fullScreen = "false";
    int quality = 0;
    int resolutionInd = 0;
    public float setVolume;

    bool doubleRes = false;

    void Start()
    {

        speedLoc = PlayerPrefs.GetInt("TextSpeedSet");
        skip = PlayerPrefs.GetString("AutoSkip");
        setVolume = PlayerPrefs.GetFloat("Volume");
        resolutionInd = PlayerPrefs.GetInt("SetResolution");
        quality = PlayerPrefs.GetInt("SetQuality");
        fullScreen = PlayerPrefs.GetString("IsFullScreen");

        audioSlider.value = setVolume;

        if (skip == "true")
            autoSkipToggle.isOn = true;
        else if (skip == "false")
            autoSkipToggle.isOn = false;

        textSpeedDropdown.value = speedLoc;

        qualityDropdown.value = quality;

        if (fullScreen == "true")
            isFull.isOn = true;
        else if (fullScreen == "false")
            isFull.isOn = false;



        resolutions = Screen.resolutions;

        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            foreach (var item in options)
            {
                if (item == option)
                {
                    doubleRes = true;
                }
                if (doubleRes == true)
                    break;
            }
            if (doubleRes == false)
                options.Add(option);
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = resolutionInd;
        resolutionDropdown.RefreshShownValue();
    }
    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen); //Get Size of Window
        resolutionInd = resolutionIndex;
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen; //Get if fullscreen
        if (isFullscreen == false)
        {
            fullScreen = "false";
        }
        else
        {
            fullScreen = "true";
        }
    }

    public void AutoSkip(bool isSkip)
    {
        autoSkip = isSkip;
        if (autoSkip == false)
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
        QualitySettings.SetQualityLevel(qualityIndex); //Get Quality of Window
        quality = qualityIndex;
    }



    public void SetTextSpeed(int textSpeed)
    {
        speed = textSpeeds[textSpeed];
        speedLoc = textSpeed;
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("TextSpeedSet", speedLoc);
        PlayerPrefs.SetString("AutoSkip", skip);
        PlayerPrefs.SetFloat("Volume", setVolume);
        PlayerPrefs.SetInt("SetResolution", resolutionInd);
        PlayerPrefs.SetInt("SetQuality", quality);
        PlayerPrefs.SetString("IsFullScreen", fullScreen);
    }
}
