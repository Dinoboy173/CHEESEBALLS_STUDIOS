using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public InSceneSettings settings;

    public AudioManager audioManager;

    public string theme = "";
    public float time = 0;

    void Start()
    {
        if (theme == "")
        {
            settings.GetSettings();
            theme = settings.clip;
            time = settings.audioTime;
        }

        audioManager.time = time; // have menu move music time over to intro and map
        audioManager.Play(theme);
        audioManager.SetSettings();
    } // make loop

    // stop sound music when leaving beach, cave, mansion
}
