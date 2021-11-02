using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public void NewGameButton()
    {
        Debug.Log("New Game");

        string sceneName = "IntroScene";

        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
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

    public void HelpButton()
    {
        Debug.Log("Help");
    }
}