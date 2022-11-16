using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject foodPlate;
    public float maganitude;
    public Vector3 forceRightPos;
    public Vector3 forceRightVec;
    public Vector3 forceLeftVec;
    public Vector3 forceLeftPos;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            //foodPlate.GetComponent<Transform>().Rotate(Vector3.forward, rotateAngle);

            foodPlate.GetComponent<Rigidbody2D>().AddForceAtPosition(forceLeftVec * maganitude, forceLeftPos);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            foodPlate.GetComponent<Rigidbody2D>().AddForceAtPosition(forceRightVec * -1 * maganitude, forceRightPos);
        }
    }
}
