using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public GameObject mysaveMenu;
    string saveKey = "SaveKey";

    public Button save1;
    public Button save2;
    public Button save3;

    public Button load1;
    public Button load2;
    public Button load3;

    public Button quit;


    void Start()
    {

    }


    void Update()
    {
        SaveCheck();
        //LoadCheck();
        QuitCheck();
    }

    void QuitCheck()
    {
        quit.onClick.AddListener(AutoChange);
    }

    void AutoChange()
    {
        mysaveMenu.GetComponent<SaveMenu>().saveDataKey = "ASaveKey";
    }



    void SaveCheck()
    {
        save1.onClick.AddListener(SaveBox1);
        save2.onClick.AddListener(SaveBox2);
        save3.onClick.AddListener(SaveBox3);
    }

    void LoadCheck()
    {
        load1.onClick.AddListener(LoadBox1);
        load2.onClick.AddListener(LoadBox2);
        load3.onClick.AddListener(LoadBox3);
    }


    void SaveBox1()
    {
        mysaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey1";
    }
    void SaveBox2()
    {
        mysaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey2";
    }
    void SaveBox3()
    {
        mysaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey3";
    }

    void LoadBox1()
    {
        mysaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey1";
    }
    void LoadBox2()
    {
        mysaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey2";
    }
    void LoadBox3()
    {
        mysaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey3";
    }

}
