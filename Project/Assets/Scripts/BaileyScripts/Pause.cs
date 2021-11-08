using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Pause : MonoBehaviour
{

    public Flowchart flowchart;
    public GameObject pauseScreen;
    public Button resumeButton;

    string currentBlock = "Filler";

    void Update()
    {
        currentBlock = flowchart.GetStringVariable("Box");
        if(Input.GetMouseButtonDown(0))
        resumeButton.onClick.AddListener(CallBlock);
    }

    void CallBlock()
    {

        flowchart.ExecuteBlock(currentBlock);
        pauseScreen.SetActive(false);
    }
}
