using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelection : MonoBehaviour
{
    public List<RotateObject> rotatingObjects;

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
                if (hoveredObject != selectable)
                    StopHovering();

                hoveredObject = selectable;

                hoveredObject.DoHover(true);

                if (rotatingObjects.Count != 0)
                {
                    foreach (var rot in rotatingObjects)
                    {
                        if (rot.transform.parent == hoveredObject.transform)
                        {
                            rot.RotateTowardsCamera();
                        }
                    }
                }

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