using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animatorPlayer : MonoBehaviour
{
    Animator animator;
    public bool timeEnd;
    public GameObject TimeManager;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        TimeCountdown externalTime = TimeManager.GetComponent<TimeCountdown>();
        timeEnd = externalTime.timeEnd;

        if (timeEnd == true)
        {
            animator.SetBool("cameraTrigger", true);
        }
    }
}
