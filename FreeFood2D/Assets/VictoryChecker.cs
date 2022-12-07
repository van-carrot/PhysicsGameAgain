using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictoryChecker : MonoBehaviour
{
    public GameObject victoryScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x >= 68)
        {
            victoryScreen.SetActive(true);
        }
    }
}
