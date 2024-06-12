using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletPref;

    public float firePower;



    void Start()
    {
        Cursor.visible = false;

        Cursor.lockState = CursorLockMode.Confined;
    }

  
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
           GameObject bullet = Instantiate(bulletPref,
               transform.position + transform.forward, Quaternion.identity);

            bullet.GetComponent<Rigidbody>()
                .AddForce(transform.forward*firePower, ForceMode.Impulse);
        }
    }
}
