using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolderYRotate : MonoBehaviour
{
    const float rotateSpeed = 45f;
    const float mouseRotateSpeed = 3f;
    const string leftRotate = "a";
    const string rightRotate = "d";

    void Update()
    {

        if(Input.GetKey(leftRotate))
        {
            transform.Rotate(0,rotateSpeed*Time.deltaTime,0);
        }

        if(Input.GetKey(rightRotate))
        {
            transform.Rotate(0,-rotateSpeed*Time.deltaTime,0);
        }

        if(Input.GetMouseButton(2))
        {
            transform.Rotate(0,Input.GetAxis("Mouse X")*mouseRotateSpeed,0);
        }
        
    }
}
