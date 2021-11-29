using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;
using UnityEngine.SceneManagement;

public class LinkFriendShipSlider : MonoBehaviour
{
    public Flowchart flowchart;
    public Slider slider;

    [Header("Debug Option")]
    public bool inRyanScene = false;

    Scene scene;

    void Update()
    {
        if (!inRyanScene)
        {
            if (scene.name == "BeachScene")
            {
                slider.value = flowchart.GetIntegerVariable("interestCheddar");
            }
            else if (scene.name == "CaveScene")
            {
                slider.value = flowchart.GetIntegerVariable("interestBlue");
            }
            else if (scene.name == "MansionScene")
            {
                slider.value = flowchart.GetIntegerVariable("interestSwiss");
            }
        }
        else
        {
            slider.value = flowchart.GetIntegerVariable("interestSwiss");
        }
    }
}
