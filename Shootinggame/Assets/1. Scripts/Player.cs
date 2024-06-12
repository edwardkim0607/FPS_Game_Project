using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float movespeed;
    public float jumpPower;
    public float rotatespeed;



    int jumpCount;

    Rigidbody rb;



    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);

        dir.Normalize();

        dir=transform.TransformDirection(dir);

        transform.position += dir * movespeed * Time.deltaTime;

        rb.MovePosition(rb.position+(dir*movespeed*Time.deltaTime));

        if(Input.GetKeyDown(KeyCode.Space)&& jumpCount<2)
        {
            rb.AddForce(Vector3.up* jumpPower, ForceMode.Impulse);
            
            jumpCount++;
           
        }

        float mouseMoveX = Input.GetAxis("Mouse X");

        transform.Rotate(0, mouseMoveX * rotatespeed * Time.deltaTime,0);
    
    
    
    
    
    
    
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Ground")
        {
            jumpCount = 0;
        }
    }






}
