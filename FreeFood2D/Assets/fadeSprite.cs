using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeSprite : MonoBehaviour
{
    Animator spriteAnimator;
    public bool endTransition;
    public GameObject cameraManager;

    // Start is called before the first frame update
    void Start()
    {
        spriteAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        CameraTransition externalCamera = cameraManager.GetComponent<CameraTransition>();
        endTransition = externalCamera.lerpFinished;

        if (endTransition == true)
        {
            spriteAnimator.SetBool("transitionFinish", true);
        }
    }
}
