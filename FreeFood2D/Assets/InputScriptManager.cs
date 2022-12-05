using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScriptManager : MonoBehaviour
{
    public GameObject camManager;
    public bool secondPhase;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        CameraTransition cam = camManager.GetComponent<CameraTransition>();
        secondPhase = cam.lerpFinished;

        if (secondPhase)
        {
            gameObject.GetComponent<InputManager2>().enabled = true;
        }
    }
}
