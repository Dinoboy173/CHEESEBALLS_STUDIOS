using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllCheesesSelected : MonoBehaviour
{
    public bool cheddarClicked = false;
    public bool swissClicked = false;
    public bool blueClicked = false;

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

        if (cheddarClicked && swissClicked && blueClicked)
        {
            god.SetActive(true);
        }
    }
}