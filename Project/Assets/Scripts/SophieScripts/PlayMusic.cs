using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioManager audioManager;

    public string theme = "";

    void Start()
    {
        audioManager.Play(theme);
    }
}
