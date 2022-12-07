using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackfadeAnimator : MonoBehaviour
{
    Animator blackscreenAnimator;
    public bool startTransition;
    public bool endTransition;
    public GameObject timeManager;
    public GameObject cameraManager;

    // Start is called before the first frame update
    void Start()
    {
        blackscreenAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        CameraTransition externalCamera = cameraManager.GetComponent<CameraTransition>();
        startTransition = externalCamera.cameraTrigger;

        if (startTransition == true)
        {
            blackscreenAnimator.SetBool("transitionStart", true);

        }

        endTransition = externalCamera.lerpFinished;

       

        if (endTransition == true)
        {
            blackscreenAnimator.SetBool("transitionEnd", true);
        }
    }
}
