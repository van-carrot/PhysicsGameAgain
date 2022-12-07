using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activateScript : MonoBehaviour
{
    public GameObject camManager;
    public bool enemyReady;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CameraTransition cam = camManager.GetComponent<CameraTransition>();
        enemyReady = cam.lerpFinished;

        if (enemyReady)
        {
            gameObject.GetComponent<SpriteChanger>().enabled = true;
        }
    }
}
