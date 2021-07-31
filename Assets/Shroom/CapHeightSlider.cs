using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapHeightSlider : AbstractSlider
{

    [SerializeField] private GameObject[] middleCapParts;
    private Vector3[] startCapPartsPosition;
    const float heightThreshold = .2f;

    void OnValidate()
    {
        startCapPartsPosition = new Vector3[middleCapParts.Length];
        for(int i=0;i<middleCapParts.Length;i++)
        {
            startCapPartsPosition[i] = middleCapParts[i].transform.position;
        }
    }

    public override void Action(float value)
    {
        for(int i=0;i<middleCapParts.Length;i++)
        {
            middleCapParts[i].transform.position = new Vector3(
            middleCapParts[i].transform.position.x,
            startCapPartsPosition[i].y+value*heightThreshold,
            middleCapParts[i].transform.position.z);
        }
    }

}
