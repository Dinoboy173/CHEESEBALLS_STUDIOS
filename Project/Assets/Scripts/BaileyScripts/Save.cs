using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public GameObject mySaveMenu;
    public Button saveMenuButton;
    string saveKey = "SaveKey";

    bool isMenuOn = false;

    public Button resume;
    public GameObject myPauseMenu;

    public Button setSave1;
    public Button setSave2;
    public Button setSave3;

    public Button setLoad1;
    public Button setLoad2;
    public Button setLoad3;

    public Button quitSave;
    public Button quitLoad;
    public Button quitGame;

    public Button save;
    public Button load;

    void Start()
    {
        //saveMenuButton.onClick.Invoke();
    }


    void Update()
    {
        SaveCheck();
        //LoadCheck();
        QuitCheck();
        if (myPauseMenu.activeSelf == true && isMenuOn == false)
        {
            isMenuOn = true;
            saveMenuButton.onClick.Invoke();
        }


        if (isMenuOn == true)
            resume.onClick.AddListener(SaveMenuOff);

    }

    void SaveMenuOff()
    {
        isMenuOn = false;
        saveMenuButton.onClick.Invoke();
    }

    void QuitCheck()
    {
        quitSave.onClick.AddListener(AutoChange);
        //quitLoad.onClick.AddListener(AutoChange);
    }

    void AutoChange()
    {
        mySaveMenu.GetComponent<SaveMenu>().saveDataKey = "ASaveKey";
    }



    void SaveCheck()
    {
        setSave1.onClick.AddListener(SaveBox1);
        setSave2.onClick.AddListener(SaveBox2);
        setSave3.onClick.AddListener(SaveBox3);
    }

    void LoadCheck()
    {
        setLoad1.onClick.AddListener(LoadBox1);
        setLoad2.onClick.AddListener(LoadBox2);
        setLoad3.onClick.AddListener(LoadBox3);
    }


    void SaveBox1()
    {
        mySaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey1";
    }
    void SaveBox2()
    {
        mySaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey2";
    }
    void SaveBox3()
    {
        mySaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey3";
    }

    void LoadBox1()
    {
        mySaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey1";
    }
    void LoadBox2()
    {
        mySaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey2";
    }
    void LoadBox3()
    {
        mySaveMenu.GetComponent<SaveMenu>().saveDataKey = "MSaveKey3";
    }

}
