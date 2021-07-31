using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GillsSlider : AbstractSlider
{

    [SerializeField]private GameObject gillsObject;
    const float gillsThreshold = 2f;


    public override void Action(float value)
    {
        gillsObject.transform.localScale = new Vector3(3+value*gillsThreshold,1,1);
    }

}
