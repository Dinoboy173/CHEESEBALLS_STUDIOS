using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class Pause : MonoBehaviour
{

    public Flowchart flowchart;
    public GameObject pauseScreen;
    public Button resumeButton;
    public List<Block> blocks;

    string currentBlock = "Filler";

    void Start()
    {
       // flowchart = Flowchart.Find("Flowchart");
       // flowchart = FindObjectOfType(Flowchart);
       
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        { 
            blocks = flowchart.GetExecutingBlocks(); 
            if(blocks.Count == 1)
            {
                currentBlock = blocks[0].BlockName;
                flowchart.StopAllBlocks();
                pauseScreen.SetActive(true);
            }
           // if (blocks.Count == 0)
           // {
           //     pauseScreen.SetActive(true);
           // }
        }


        if(Input.GetMouseButtonDown(0) && currentBlock != "Filler")
        resumeButton.onClick.AddListener(CallBlock);
    }

    void CallBlock()
    {
        
        flowchart.ExecuteBlock(currentBlock);
        pauseScreen.SetActive(false);
        currentBlock = "Filler";
    }
}
