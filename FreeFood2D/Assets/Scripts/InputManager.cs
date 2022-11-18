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

    public float spd;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            //foodPlate.GetComponent<Transform>().Rotate(Vector3.forward, rotateAngle);


            //Rotation Bowl
            foodPlate.GetComponent<Rigidbody2D>().AddForceAtPosition(forceLeftVec * maganitude, forceLeftPos);

            //Moving from right to left
            //foodPlate.transform.position += Vector3.left * spd * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {

            //Rotation Bowl
            foodPlate.GetComponent<Rigidbody2D>().AddForceAtPosition(forceRightVec * -1 * maganitude, forceRightPos);

            //Moving from left to right
            //foodPlate.transform.position += Vector3.right * spd * Time.deltaTime;

        }
    }
}
