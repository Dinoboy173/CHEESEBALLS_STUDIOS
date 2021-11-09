using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseSelection : MonoBehaviour
{
    RaycastHit hit;

    [HideInInspector] public SelectableObject hoveredObject;

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Clickable" &&
                hit.transform.TryGetComponent(out SelectableObject selectable))
            {
                if (hoveredObject != selectable)
                    StopHovering();

                hoveredObject = selectable;

                hoveredObject.DoHover(true);

                if (Input.GetMouseButtonDown(0))
                    hoveredObject.DoClick();
            }
            else
                StopHovering();
        }
        else
            StopHovering();
    }

    public void StopHovering()
    {
        if (hoveredObject != null)
        {
            hoveredObject.DoHover(false);
            hoveredObject = null;
        }
    }
}