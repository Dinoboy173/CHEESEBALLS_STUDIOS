using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FetchQuests : MonoBehaviour
{
    public bool getQuestTriggers = false;

    public Flowchart flowchart;

    [Header("Cheddar Quest Bools")]
    public bool cheddarActiveFetchQuest = false;
    public bool cheddarCompleteFetchQuest = false;
    
    [Header("Swiss Quest Bools")]
    public bool swissActiveFetchQuest = false;
    public bool swissCompleteFetchQuest = false;

    [Header("Blue Quest Bools")]
    public bool blueActiveFetchQuest = false;
    public bool blueCompleteFetchQuest = false;

    void Start()
    {
        if (getQuestTriggers)
        {
            // get cheddar
            cheddarActiveFetchQuest = PlayerPrefs.GetInt(CheeseQuestTriggers.CheddarQuestActive.ToString(), 0) != 0;
            cheddarCompleteFetchQuest = PlayerPrefs.GetInt(CheeseQuestTriggers.CheddarQuestComplete.ToString(), 0) != 0;

            // get swiss
            swissActiveFetchQuest = PlayerPrefs.GetInt(CheeseQuestTriggers.SwissQuestActive.ToString(), 0) != 0;
            swissCompleteFetchQuest = PlayerPrefs.GetInt(CheeseQuestTriggers.SwissQuestComplete.ToString(), 0) != 0;

            // get blue
            blueActiveFetchQuest = PlayerPrefs.GetInt(CheeseQuestTriggers.BlueQuestActive.ToString(), 0) != 0;
            blueCompleteFetchQuest = PlayerPrefs.GetInt(CheeseQuestTriggers.BlueQuestComplete.ToString(), 0) != 0;
        }
    }

    void Update()
    {
        
    }

    public void SetQuestTriggers()
    {
        // set cheddar
        PlayerPrefs.SetInt(CheeseQuestTriggers.CheddarQuestActive.ToString(), (cheddarActiveFetchQuest ? 1 : 0));
        PlayerPrefs.SetInt(CheeseQuestTriggers.CheddarQuestComplete.ToString(), (cheddarCompleteFetchQuest ? 1 : 0));

        // set swiss
        PlayerPrefs.SetInt(CheeseQuestTriggers.SwissQuestActive.ToString(), (swissActiveFetchQuest ? 1 : 0));
        PlayerPrefs.SetInt(CheeseQuestTriggers.SwissQuestComplete.ToString(), (swissCompleteFetchQuest ? 1 : 0));

        // set blue
        PlayerPrefs.SetInt(CheeseQuestTriggers.BlueQuestActive.ToString(), (blueActiveFetchQuest ? 1 : 0));
        PlayerPrefs.SetInt(CheeseQuestTriggers.BlueQuestComplete.ToString(), (blueCompleteFetchQuest ? 1 : 0));

        PlayerPrefs.Save();
    }
}