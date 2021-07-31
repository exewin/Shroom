using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegChild : MonoBehaviour
{

    [SerializeField]private GameObject child;
    [SerializeField]private GameObject legObject;

    public void SetParent()
    {
        child.transform.SetParent(this.transform);
    }

    public void UnsetParent()
    {
        child.transform.SetParent(legObject.transform);
    }

}
