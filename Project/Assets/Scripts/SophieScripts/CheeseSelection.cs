using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSelection : MonoBehaviour
{
    public Camera camera;
    RaycastHit hit;
    Transform objectHit = null;
    GameObject textPopup = null;

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            objectHit = hit.transform;

            if (hit.transform.tag == "Clickable")
            {
                if (!objectHit.GetChild(0).gameObject.activeInHierarchy)
                {
                    objectHit.GetChild(0).gameObject.SetActive(true);
                    textPopup = objectHit.GetChild(0).gameObject;
                }

                RotateText();
            }
            else if (hit.transform.tag == "Untagged")
            {
                if (textPopup != null)
                {
                    textPopup.SetActive(false);
                    textPopup = null;
                }
            }
        }
    }

    void RotateText()
    {
        textPopup.transform.LookAt(camera.transform, Vector3.up);
    }
}