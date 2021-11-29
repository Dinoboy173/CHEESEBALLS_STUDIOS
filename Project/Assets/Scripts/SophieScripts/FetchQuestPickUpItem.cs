using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FetchQuestPickUpItem : MonoBehaviour
{
    [Header("What Cheese Does This Belong To?")]
    public bool cheddar = false;
    public bool swiss = false;
    public bool blue = false;

    [Header("Conditions")]
    public bool isFetchQuestActive = false;
    public bool isFetchQuestComplete = false;

    [Space(10)] // is this needed?
    public FetchQuests questManager;
    public string questName = "";

    bool hasError = false;

    private void Start()
    {
        if (cheddar && !swiss && !blue)
        {
            isFetchQuestActive = questManager.cheddarActiveFetchQuest;
            isFetchQuestComplete = questManager.cheddarCompleteFetchQuest;
        }
        else if (swiss && !cheddar && !blue)
        {
            isFetchQuestActive = questManager.swissActiveFetchQuest;
            isFetchQuestComplete = questManager.swissCompleteFetchQuest;
        }
        else if (blue && !cheddar && !swiss)
        {
            isFetchQuestActive = questManager.blueActiveFetchQuest;
            isFetchQuestComplete = questManager.blueCompleteFetchQuest;
        }
        else
        {
            if (!cheddar && !swiss && !blue)
            {
                Debug.LogError("No Cheese Selected For Quest");
                hasError = !hasError;
            }
            else
            {
                Debug.LogError("Too Many Cheese Selected For Quest");
                hasError = !hasError;
            }
        }
    }

    void Update()
    {
        
    }

    public void Clicked()
    {
        if (!hasError)
        {
            this.gameObject.SetActive(false);

            isFetchQuestComplete = !isFetchQuestComplete;

            if (cheddar)
                questManager.cheddarCompleteFetchQuest = true;
            else if (swiss)
                questManager.swissCompleteFetchQuest = true;
            else if (blue)
                questManager.blueCompleteFetchQuest = true;
        }
        else
        {
            Debug.LogError("Amount Of Cheese Assigned Not Equal To One");
        }
    }
}