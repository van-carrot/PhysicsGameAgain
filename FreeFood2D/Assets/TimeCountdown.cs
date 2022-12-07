using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeCountdown : MonoBehaviour
{
    public TextMeshProUGUI timerText;

    public GameObject foodAreaManager;
    private FoodArea foodAreaScript;

    public float countdownTime;

    public bool timeEnd;

    // Start is called before the first frame update
    void Start()
    {
        timerText.text = "start";
        countdownTime = 20;
        timeEnd = false;
        foodAreaScript = foodAreaManager.GetComponent<FoodArea>();
        
    }

    // Update is called once per frame
    void Update()
    {
        countdownTime -= Time.deltaTime;

        timerText.text = "Time: " + (int)countdownTime;

        if (countdownTime <= 0)
        {
            timeEnd = true;
            GoalManager.Instance.CheckFailure();
            timerText.text = " ";
            foodAreaScript.enabled = false;
        }

    }
}
