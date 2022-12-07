using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalManager : MonoBehaviour
{
    public static GoalManager Instance;

    public int foodAmount;

    public GameObject endScreen;
    public bool isFailed = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void CheckFailure()
    {
        if(foodAmount < 0)
        {
            isFailed = true;
            endScreen.SetActive(true);
        }
    }
}
