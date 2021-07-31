using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapSizeSlider : AbstractSlider
{

    [SerializeField] private GameObject cap;
    const float threshold = .5f;



    public override void Action(float value)
    {
        cap.transform.localScale = new Vector3(.7f+value*threshold,cap.transform.localScale.y,.7f+value*threshold);
    }

}
