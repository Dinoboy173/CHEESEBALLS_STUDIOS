using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class LinkFriendShipSlider : MonoBehaviour
{
    public Flowchart flowchart;
    public Slider slider;

    public Scenes scene;

    void Update()
    {
        if (scene == Scenes.BeachScene)
        {
            slider.value = flowchart.GetIntegerVariable("interestCheddar");
        }
        else if (scene == Scenes.CaveScene)
        {
            slider.value = flowchart.GetIntegerVariable("interestBlue");
        }
        else if (scene == Scenes.MansionScene)
        {
            slider.value = flowchart.GetIntegerVariable("interestSwiss");
        }
    }
}
