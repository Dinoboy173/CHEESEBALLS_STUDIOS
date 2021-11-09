using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public void RotateTowardsCamera()
    {
        transform.LookAt(Camera.main.transform);
    }
}