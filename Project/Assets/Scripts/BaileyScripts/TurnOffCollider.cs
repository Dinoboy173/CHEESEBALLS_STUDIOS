using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffCollider : MonoBehaviour
{

    public GameObject Hut;
    public GameObject Mansion;
    public GameObject Cave;
    public GameObject PauseHandler;

    void Update()
    {
        if (PauseHandler.activeInHierarchy == true)
            ColliderOff();
        else
        {
            ColliderOn();
        }

    }

    void ColliderOff()
    {
       
        Collider hutCollider = Hut.GetComponent<SphereCollider>();
        Collider mansionCollider = Mansion.GetComponent<SphereCollider>();
        Collider caveCollider = Cave.GetComponent<SphereCollider>();
        hutCollider.enabled = false;
        mansionCollider.enabled = false;
        caveCollider.enabled = false;
    }

    void ColliderOn()
    {

        Collider hutCollider = Hut.GetComponent<SphereCollider>();
        Collider mansionCollider = Mansion.GetComponent<SphereCollider>();
        Collider caveCollider = Cave.GetComponent<SphereCollider>();
        hutCollider.enabled = true;
        mansionCollider.enabled = true;
        caveCollider.enabled = true;
    }
}
