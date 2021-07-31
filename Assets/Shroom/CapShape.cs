using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapShape : MonoBehaviour
{

    [SerializeField] private GameObject[] allCapParts;
    const float maxRandomizeScale = 1.3f; 
    const float minRandomizeScale = 0.8f; 

    public void RandomShape()
    {
        foreach (var part in allCapParts)
        {
            float rand = Random.Range(minRandomizeScale,maxRandomizeScale);
            part.transform.localScale = new Vector3(rand,rand,rand);
        }
    }

    public void SmoothShape()
    {
        foreach (var part in allCapParts)
        {
            part.transform.localScale = new Vector3(1,1,1);
        }
    }

}
