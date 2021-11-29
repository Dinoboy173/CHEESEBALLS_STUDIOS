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
    public List<Button> menuDialogButtons;
    List<bool> Buttons = new List<bool>();

    public List<Collider> clickableObjects;

    string currentBlock = "Filler";
    Block CommandHolder;
    int cmdIndex = 0;

    bool isButtonOneOn = false;
    bool isButtonTwoOn = false;
    bool isButtonThreeOn = false;
    bool isButtonFourOn = false;
    bool isButtonFiveOn = false;

    bool allButtonsOff = false;

    void Awake()
    {
        // flowchart = Flowchart.Find("Flowchart");
        // flowchart = FindObjectOfType(Flowchart);

        Buttons.Add(isButtonOneOn);
        Buttons.Add(isButtonTwoOn);
        Buttons.Add(isButtonThreeOn);
        Buttons.Add(isButtonFourOn);
        Buttons.Add(isButtonFiveOn);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            //for (int i = 0; i < menuDialogButtons.Count; i++)
            //{
            //    if (menuDialogButtons[i].gameObject.active)
            //        Buttons[i] = true;
            //}
            //
            //if (!isButtonOneOn &&
            //    !isButtonTwoOn &&
            //    !isButtonThreeOn &&
            //    !isButtonFourOn &&
            //    !isButtonFiveOn)
            //{
            //    allButtonsOff = true;
            //}
            //else
            //    allButtonsOff = false;

            blocks = flowchart.GetExecutingBlocks(); 
            if(blocks.Count == 1)
            {
                currentBlock = blocks[0].BlockName;
                flowchart.StopAllBlocks();
                pauseScreen.SetActive(true);
            }
            else if (blocks.Count == 0 && allButtonsOff)
            {
                pauseScreen.SetActive(true);

                if (clickableObjects.Count != 0)
                {
                    foreach (Collider obj in clickableObjects)
                    {
                        obj.enabled = false;
                    }
                }
            }
        }

        if(Input.GetMouseButtonDown(0) && currentBlock != "Filler")
            resumeButton.onClick.AddListener(CallBlock);
    }

    void CallBlock()
    {
        Block currentBlockFungus = flowchart.FindBlock(currentBlock);
        cmdIndex = currentBlockFungus.PreviousActiveCommandIndex;
        while(currentBlockFungus.CommandList.Count < cmdIndex)
        {
            cmdIndex--;
        }
        flowchart.ExecuteBlock(currentBlockFungus, cmdIndex + 1);
        pauseScreen.SetActive(false);
        currentBlock = "Filler";
        cmdIndex = 0;
    }
}
