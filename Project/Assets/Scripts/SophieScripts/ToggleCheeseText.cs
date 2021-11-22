using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class ToggleCheeseText : MonoBehaviour
{
    public Flowchart flowchart;
    public SelectingCheese camera;

    public void ToggleCheddar()
    {
        if (!camera.isEndGame)
            flowchart.ExecuteBlock("Cheddar");
        else
            flowchart.ExecuteBlock("CantChoose");
    }

    public void ToggleSwiss()
    {
        if (!camera.isEndGame)
            flowchart.ExecuteBlock("Swiss");
        else
            flowchart.ExecuteBlock("CantChoose");
    }

    public void ToggleBlue()
    {
        if (!camera.isEndGame)
            flowchart.ExecuteBlock("Blue");
        else
            flowchart.ExecuteBlock("CantChoose");
    }
}
