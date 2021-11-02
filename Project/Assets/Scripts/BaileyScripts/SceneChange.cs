using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{

    public void Cave()
    {
        SceneManager.LoadScene(1);
    }

    public void Mansion()
    {
        SceneManager.LoadScene(4);
    }

    public void Beach()
    {
        SceneManager.LoadScene(3);
    }

    public void Map()
    {
        SceneManager.LoadScene(1);
    }
}
