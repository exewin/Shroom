using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolderXRotate : MonoBehaviour
{
    const float rotateSpeed = 45f;
    const float mouseRotateSpeed = 3f;
    const string upRotate = "w";
    const string downRotate = "s";

    void Update()
    {

        if(Input.GetKey(upRotate))
        {
            transform.Rotate(0,0,-rotateSpeed*Time.deltaTime);
        }

        if(Input.GetKey(downRotate))
        {
            transform.Rotate(0,0,rotateSpeed*Time.deltaTime);
        }

        if(Input.GetMouseButton(2))
        {
            transform.Rotate(0,0,Input.GetAxis("Mouse Y")*mouseRotateSpeed);
        }
        
    }
}
