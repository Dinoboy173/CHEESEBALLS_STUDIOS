using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCoverStartTime : MonoBehaviour
{
    public ParticleSystem particle;

    public bool manualSetStartTime = false;
    public float startTime = 0f;

    void Awake()
    {
        if (manualSetStartTime)
        {
            particle.Simulate(startTime);
            particle.Play();
        }
            
    }
}
