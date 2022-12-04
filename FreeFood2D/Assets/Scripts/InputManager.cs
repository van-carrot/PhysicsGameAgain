using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public GameObject foodPlate;
    public float magnitude;
    private HingeJoint2D balanceBoard;
    //public Vector3 forceRightPos;
    //public Vector3 forceRightVec;
    //public Vector3 forceLeftVec;
    //public Vector3 forceLeftPos;

    //public float spd;

    private void Start()
    {
        balanceBoard = foodPlate.GetComponent<HingeJoint2D>();
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            balanceBoard.useMotor = true;

            JointMotor2D motor = new JointMotor2D { motorSpeed = magnitude, maxMotorTorque = 10000 };
            balanceBoard.motor = motor;

            //foodPlate.GetComponent<Transform>().Rotate(Vector3.forward, rotateAngle);


            //Rotation Bowl
            //foodPlate.GetComponent<Rigidbody2D>().AddForceAtPosition(forceLeftVec * magnitude, forceLeftPos);

            //Moving from right to left
            //foodPlate.transform.position += Vector3.left * spd * Time.deltaTime;

        }
        else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            balanceBoard.useMotor = true;
            JointMotor2D motor = new JointMotor2D { motorSpeed = -magnitude, maxMotorTorque = 10000 };
            balanceBoard.motor = motor;
            //Rotation Bowl
            //foodPlate.GetComponent<Rigidbody2D>().AddForceAtPosition(forceRightVec * -1 * magnitude, forceRightPos);

            //Moving from left to right
            //foodPlate.transform.position += Vector3.right * spd * Time.deltaTime;

        }
        else
        {
            JointMotor2D motor = new JointMotor2D { motorSpeed = 0, maxMotorTorque = 10000 };
            balanceBoard.motor = motor;
            balanceBoard.useMotor = false;
        }
    }
}
