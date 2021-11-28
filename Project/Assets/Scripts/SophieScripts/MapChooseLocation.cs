using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class MapChooseLocation : MonoBehaviour
{
    public string blockName = "";
    public Flowchart flowchart;

    public void InvokeBlock()
    {
        if (blockName != "")
        {
            flowchart.ExecuteBlock(blockName);
        }
    }
}
