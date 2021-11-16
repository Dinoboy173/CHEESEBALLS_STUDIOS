using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroyOnLoad : MonoBehaviour
{

    private static DontDestroyOnLoad objectInstance;
    void Awake()
    {      
        //if(objectInstance == null)
        //{
        //    objectInstance = this;
          DontDestroyOnLoad(this);
        //}
        //else
        //{
        //    Destroy(gameObject);
        //}
    }

}
