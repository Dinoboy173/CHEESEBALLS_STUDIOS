using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void Cave()
    {
        SceneManager.LoadScene("CaveScene");
    }

    public void Mansion()
    {
        SceneManager.LoadScene("MansionScene");
    }

    public void Beach()
    {
        SceneManager.LoadScene("BeachScene");
    }

    public void Map()
    {
        SceneManager.LoadScene("MapScene");
    }

}
