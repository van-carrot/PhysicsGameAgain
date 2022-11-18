using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowl2 : MonoBehaviour
{
    public bool isOutLimit;
    public Vector3 initialPos;

    private void Start()
    {
        initialPos = transform.position;
    }
    private void FixedUpdate()
    {
        //transform.position = initialPos;

        if (transform.rotation.z < -0.3 || transform.rotation.z > 0.3)
        {
            isOutLimit = true;
        }
        else
        {
            isOutLimit = false;
        }

        if (isOutLimit)
        {
            if (transform.rotation.z < -0.3)
            {
                transform.rotation = new Quaternion(0, 0, -0.3f, transform.rotation.w);
                GetComponent<Rigidbody2D>().angularVelocity = 0;
            }
            else
            {
                transform.rotation = new Quaternion(0, 0, 0.3f, transform.rotation.w);
                GetComponent<Rigidbody2D>().angularVelocity = 0;
            }
        }


    }
}
