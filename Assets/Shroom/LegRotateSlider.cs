using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegRotateSlider : AbstractSlider
{
    [SerializeField] private GameObject[] legParts;
    [SerializeField] private twistDirection direction;
    const float threshold = 33f;

    const float startY = 90f;
    const float startZ = 90f;

    public override void Action(float value)
    {
        for(int i=0;i<legParts.Length;i++)
        {
            legParts[i].GetComponent<LegChild>().SetParent();
        }

        if(direction==twistDirection.x)
        {
            legParts[0].transform.localEulerAngles = 
            new Vector3(value*threshold,legParts[0].transform.localEulerAngles.y,legParts[0].transform.localEulerAngles.z);
        }
        else if(direction==twistDirection.y)
        {
            legParts[0].transform.localEulerAngles = 
            new Vector3(legParts[0].transform.localEulerAngles.x,startY+value*threshold,legParts[0].transform.localEulerAngles.z);
        }
        else if(direction==twistDirection.z)
        {
            legParts[0].transform.localEulerAngles = 
            new Vector3(legParts[0].transform.localEulerAngles.x,legParts[0].transform.localEulerAngles.y,startZ+value*threshold);
        }
        else
        {
            Debug.LogError("wrong direction");
        }

        for(int i=0;i<legParts.Length;i++)
        {
            legParts[i].GetComponent<LegChild>().UnsetParent();
        }
    }

}
