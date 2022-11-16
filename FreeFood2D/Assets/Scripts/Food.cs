using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum FoodType
{
    square,cicrle,capusle
}

public class Food : MonoBehaviour
{
    public bool isGrabbed; 
    public Vector3 gap;
    public FoodType type;

    private void OnMouseDrag()
    {
        ByMouseDrag();
    }

    private void OnMouseUp()
    {
        GetComponent<Rigidbody2D>().gravityScale = 1;
        ResetFoodArea();
    }

    public void ResetFoodArea()
    {
        FoodArea foodArea = FindObjectOfType<FoodArea>();
        if(type == FoodType.square)
        {
            foodArea.isSquareOut = true;
        }
        else if(type == FoodType.cicrle)
        {
            foodArea.isCircleOut = true;
        }
        else if(type == FoodType.capusle)
        {
            foodArea.isCapsuleOut = true;
        }
    }

    public void ByMouseDrag()
    {
        if (!isGrabbed)
        {
            gap = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position) + Vector3.forward * 10;
            this.GetComponentInChildren<SpriteRenderer>().sortingOrder = 11;
            MouseManager.Instance.targetObject = this.gameObject;

            isGrabbed = true;
        }

        MouseManager.Instance.DragByTheMouse(this.gameObject, -gap);
    }
}
