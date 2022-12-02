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


    public List<GameObject> foodPrefabs;
    public float foodGenerateCD;
    public GameObject startingPoint;
    public float timeCD;
    
    public GameObject RandomFoodGenerator()
    {
        GameObject comingFood = Instantiate(foodPrefabs[Random.Range(0, foodPrefabs.Count)]);

        return comingFood;
    }

    // Update is called once per frame
    void Update()
    {
        timeCD += Time.deltaTime;
        if(timeCD > foodGenerateCD)
        {
            timeCD = 0;
            GenerateFood(RandomFoodGenerator(), startingPoint);
        }
/*        if (isSquareOut)
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
        }*/
    }

    public void GenerateFood(GameObject food,GameObject slot)
    {
        food.transform.SetParent(slot.transform);
        food.transform.localPosition = Vector3.zero;
    }
}
