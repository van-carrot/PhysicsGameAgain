using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodArea : MonoBehaviour
{
    public bool isSquareOut;
    public GameObject squareSlot;
    public GameObject squarePrefab;
    public bool isCircleOut;
    public GameObject circleSlot;
    public GameObject circlePrefab;
    public bool isCapsuleOut;
    public GameObject capsuleSlot;
    public GameObject capsulePrefab;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSquareOut)
        {
            isSquareOut = false;
            GenerateFood(squarePrefab,squareSlot);
        }

        if (isCircleOut)
        {
            isCircleOut = false;
            GenerateFood(circlePrefab,circleSlot);
        }

        if (isCapsuleOut)
        {
            isCapsuleOut = false;
            GenerateFood(capsulePrefab, capsuleSlot);
        }
    }

    public void GenerateFood(GameObject foodPrefab,GameObject slot)
    {
        GameObject food = Instantiate(foodPrefab);
        food.transform.SetParent(slot.transform);
        food.transform.localPosition = Vector3.zero;
    }
}
