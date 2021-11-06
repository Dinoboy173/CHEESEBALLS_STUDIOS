using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSelection : MonoBehaviour
{
    public Camera camera;
    RaycastHit hit;
    Transform objectHit = null;
    GameObject selectedText = null;

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            objectHit = hit.transform;

            if (hit.transform.tag == "Clickable")
            {
                objectHit.GetChild(0).gameObject.SetActive(true);

                // make text rotate to player with function
            }
            else
            {
                selectedText.SetActive(false);
            }
        }

        selectedText = objectHit.GetChild(0).gameObject;
    }
}