using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public GameObject mysaveMenu;
    string saveKey = "SaveKey";
    //private SaveMenu saveMenu1;

    // Start is called before the first frame update
    void Start()
    {
        //saveKey = saveMenu.GetComponent<SaveMenu>().saveDataKey;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Backspace))
        mysaveMenu.GetComponent<SaveMenu>().saveDataKey = saveKey;
    }
}
