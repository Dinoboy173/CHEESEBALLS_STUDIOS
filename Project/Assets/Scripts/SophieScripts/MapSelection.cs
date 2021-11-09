using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapSelection : MonoBehaviour
{
    RaycastHit hit;

    [HideInInspector] public SelectableObject hoveredObject;

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == "Clickable" &&
                hit.transform.TryGetComponent(out SelectableObject selectable))
            {

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
