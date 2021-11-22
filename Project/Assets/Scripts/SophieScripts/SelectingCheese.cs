using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectingCheese : MonoBehaviour
{
    public bool isEndGame = false;
    public GameObject dialogBox;

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
    public GameObject god;

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
                god.SetActive(true);
        }
    }
}