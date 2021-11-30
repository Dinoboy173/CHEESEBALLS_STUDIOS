using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class SelectingCheese : MonoBehaviour
{
    public bool isEndGame = false;
    public GameObject dialogBox;
    public Flowchart flowchart;

    [Space(10)]

    public bool cheddarClicked = false;
    public bool swissClicked = false;
    public bool blueClicked = false;

    [Space(10)]

    public ComicSlideShow cheddarEnd;
    public ComicSlideShow blueEnd;
    public ComicSlideShow swissEnd;

    [Space(10)]

    public SelectableObject cheddar;
    public SelectableObject swiss;
    public SelectableObject blue;
    public GameObject decidingSlides;
    
    void Update()
    {
        if (!cheddarClicked)
            if (cheddar.clicked)
                cheddarClicked = !cheddarClicked;

        if (!swissClicked)
            if (swiss.clicked)
                swissClicked = !swissClicked;

        if (!blueClicked)
            if (blue.clicked)
                blueClicked = !blueClicked;

        if (isEndGame)
        {
            int interestSwiss = flowchart.GetIntegerVariable("interestSwiss");
            int interestCheddar = flowchart.GetIntegerVariable("interestCheddar");
            int interestBlue = flowchart.GetIntegerVariable("interestBlue");

            if (cheddarClicked)
            {
                cheddarEnd.gameObject.SetActive(true);
                dialogBox.SetActive(false);
            }

            if (swissClicked)
            {
                swissEnd.gameObject.SetActive(true);
                dialogBox.SetActive(false);
            }

            if (blueClicked)
            {
                blueEnd.gameObject.SetActive(true);
                dialogBox.SetActive(false);
            }
        }
        else
        {
            if (cheddarClicked && swissClicked && blueClicked)
            {
                if (!dialogBox.active)
                {
                    decidingSlides.SetActive(true);
                    dialogBox.SetActive(false);
                    cheddar.gameObject.SetActive(false);
                    swiss.gameObject.SetActive(false);
                    blue.gameObject.SetActive(false);
                }
            }
        }
    }
}