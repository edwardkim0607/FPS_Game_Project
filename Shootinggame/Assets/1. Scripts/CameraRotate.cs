using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float rotatespeed;

    float tempX;

    void Start()
    {
        
    }

    
    void Update()
    {
        float mouseMoveY = Input.GetAxis("Mouse Y");

        transform.Rotate(-mouseMoveY * rotatespeed * Time.deltaTime, 0, 0);

        if(transform.eulerAngles.x>180)
        {
            tempX=transform.eulerAngles.x-360;
        }
        else
        {
            tempX = transform.eulerAngles.x;
        }

        tempX = Mathf.Clamp(tempX, -30, 30);

        transform.eulerAngles= new Vector3 (tempX, 0, 0);

        transform.eulerAngles
            = new Vector3(tempX, transform.eulerAngles.y, transform.eulerAngles.z);
    
    
    
    
    }
}
