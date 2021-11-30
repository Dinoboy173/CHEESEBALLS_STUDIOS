using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;

public class FetchQuestPickUpItem : MonoBehaviour
{
    // variable to not appear
    // change active to can be collected
    // change complete to collected

    public Scenes scene;

    // Beach fungus variable names
    string beachCollectable = "beachCollectable";
    string beachCollected = "beachCollected";

    // Cave fungus variable names
    string caveCollectable = "caveCollectable";
    string caveCollected = "caveCollected";

    // Mansion fungus variable names
    string mansionCollectable = "mansionCollectable";
    string mansionCollected = "mansionCollected";

    string sCollectable = "";
    string sCollected = "";

    [Header("Conditions")]
    public bool isCollectable = false;
    public bool isCollected = false;

    [Space(10)]
    public FetchQuests questManager; // is the needed
    public Flowchart flowchart;

    private void Awake()
    {
        if (scene == Scenes.BeachScene)
        {
            sCollectable = beachCollectable;
            sCollected = beachCollected;
        }
        else if (scene == Scenes.CaveScene)
        {
            sCollectable = caveCollectable;
            sCollected = caveCollected;
        }
        else if (scene == Scenes.MansionScene)
        {
            sCollectable = mansionCollectable;
            sCollected = mansionCollected;
        }

        isCollectable = flowchart.GetBooleanVariable(sCollectable);
        isCollected = flowchart.GetBooleanVariable(sCollected);

        if (isCollected)
            this.gameObject.SetActive(false);
    }

    void Update()
    {
        if (flowchart.GetBooleanVariable(sCollectable) && !isCollectable)
            isCollectable = true;

        if (Input.GetKeyDown(KeyCode.F5))
            flowchart.ExecuteBlock("Fetch Quest Start");
    }

    public void Clicked()
    {
        if (isCollectable)
        {
            this.gameObject.SetActive(false);

            isCollected = !isCollected;
            isCollectable = !isCollectable;
            flowchart.SetBooleanVariable(sCollectable, false);
            flowchart.SetBooleanVariable(sCollected, true);
        }
    }
}