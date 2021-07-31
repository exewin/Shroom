using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapBoneTwistSlider : AbstractSlider
{

    [SerializeField] private GameObject capPart;
    [SerializeField] private twistDirection direction;
    const float threshold = 45f;


    public override void Action(float value)
    {
        if(direction==twistDirection.x)
        {
            capPart.transform.localEulerAngles = 
            new Vector3(value*threshold,capPart.transform.localEulerAngles.y,capPart.transform.localEulerAngles.z);
        }
        else if(direction==twistDirection.y)
        {
            capPart.transform.localEulerAngles = 
            new Vector3(capPart.transform.localEulerAngles.x,value*threshold,capPart.transform.localEulerAngles.z);
        }
        else if(direction==twistDirection.z)
        {
            capPart.transform.localEulerAngles = 
            new Vector3(capPart.transform.localEulerAngles.x,capPart.transform.localEulerAngles.y,value*threshold);
        }
        else
        {
            Debug.LogError("wrong direction");
        }
    }


}