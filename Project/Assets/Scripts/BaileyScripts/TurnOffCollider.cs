using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCollider : MonoBehaviour
{

    public GameObject hut; // or left cheese
    public GameObject mansion; // or middle cheese
    public GameObject cave; // or right cheese
    public GameObject pauseHandler;
    bool isPauseOn = false;

    void Update()
    {
        for(int i = 0; i < pauseHandler.transform.childCount; i++)
        {
            if (pauseHandler.transform.GetChild(i).gameObject.activeInHierarchy)
            {
                ColliderOff();
                isPauseOn = true;
            }
        }

        if(isPauseOn == false)
        {
            ColliderOn();
        }

    }

    void ColliderOff()
    {
       
        Collider hutCollider = hut.GetComponent<SphereCollider>();
        Collider mansionCollider = mansion.GetComponent<SphereCollider>();
        Collider caveCollider = cave.GetComponent<SphereCollider>();
        hutCollider.enabled = false;
        mansionCollider.enabled = false;
        caveCollider.enabled = false;
    }

    void ColliderOn()
    {

        Collider hutCollider = hut.GetComponent<SphereCollider>();
        Collider mansionCollider = mansion.GetComponent<SphereCollider>();
        Collider caveCollider = cave.GetComponent<SphereCollider>();
        hutCollider.enabled = true;
        mansionCollider.enabled = true;
        caveCollider.enabled = true;
    }
}
