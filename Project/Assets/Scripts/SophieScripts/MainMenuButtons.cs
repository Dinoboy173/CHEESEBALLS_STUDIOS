using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuButtons : MonoBehaviour
{
    public GameObject slides;

    public void NewGameButton()
    {
        Debug.Log("New Game");

        slides.SetActive(true);
    }

    public void LoadGameButton()
    {
        Debug.Log("Load Game");
    }

    public void SettingsButton()
    {
        Debug.Log("Settings");
    }

    public void CreditsButton()
    {
        Debug.Log("Credits");
    }

    public void ExitButton()
    {
        Debug.Log("Exit");

        Application.Quit();
    }
}