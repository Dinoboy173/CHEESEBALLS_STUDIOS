using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCollider : MonoBehaviour
{

    public GameObject hut; // or left cheese
    public GameObject mansion; // or middle cheese
    public GameObject cave; // or right cheese

    public GameObject blue; // or left cheese
    public GameObject chedder; // or middle cheese
    public GameObject swiss; // or right cheese

    public GameObject pauseHandler;
    bool isPauseOn = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        for(int i = 0; i < pauseHandler.transform.childCount; i++)
        {
            if (pauseHandler.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                ColliderOff();
                isPauseOn = true;
                break;
            }
            isPauseOn = false;
        }
    }

    void ColliderOff()
    {
        if (hut)
        {
            Collider hutCollider = hut.GetComponent<SphereCollider>();
            Collider mansionCollider = mansion.GetComponent<SphereCollider>();
            Collider caveCollider = cave.GetComponent<SphereCollider>();
            hutCollider.enabled = false;
            mansionCollider.enabled = false;
            caveCollider.enabled = false;
        }
        else if(swiss)
        {
            Collider blueCollider= swiss.GetComponent<MeshCollider>();
            Collider chedderCollider = blue.GetComponent<MeshCollider>();
            Collider swissCollider = chedder.GetComponent<MeshCollider>();
            blueCollider.enabled = false;
            chedderCollider.enabled = false;
            swissCollider.enabled = false;
        }
    }

    public void ColliderOn()
    {
        if (hut)
        {
            Collider hutCollider = hut.GetComponent<SphereCollider>();
            Collider mansionCollider = mansion.GetComponent<SphereCollider>();
            Collider caveCollider = cave.GetComponent<SphereCollider>();
            hutCollider.enabled = true;
            mansionCollider.enabled = true;
            caveCollider.enabled = true;
        }
        else if (swiss)
        {
            Collider blueCollider = swiss.GetComponent<MeshCollider>();
            Collider chedderCollider = blue.GetComponent<MeshCollider>();
            Collider swissCollider = chedder.GetComponent<MeshCollider>();
            blueCollider.enabled = true;
            chedderCollider.enabled = true;
            swissCollider.enabled = true;
        }

    }
}
