using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class AbstractSlider : MonoBehaviour
{
    protected Slider thisSlider;
    void Awake()
    {
        thisSlider = GetComponent<Slider>();
    }

    public void SliderMove()
    {
        Action(thisSlider.value);
    }

    public virtual void Action(float value){}
}
