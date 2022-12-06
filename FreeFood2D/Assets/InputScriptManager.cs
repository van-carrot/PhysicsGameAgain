using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputScriptManager : MonoBehaviour
{
    public GameObject camManager;
    public GameObject foodPlate;
    public bool secondPhase;
    private Rigidbody2D foodRb;


    // Start is called before the first frame update
    void Start()
    {
        foodRb = foodPlate.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        CameraTransition cam = camManager.GetComponent<CameraTransition>();
        secondPhase = cam.lerpFinished;

        if (secondPhase)
        {
            gameObject.GetComponent<InputManager2>().enabled = true;
            foodRb.constraints = RigidbodyConstraints2D.FreezePositionY;
        }
    }
}
