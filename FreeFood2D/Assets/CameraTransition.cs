using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTransition : MonoBehaviour
{
    public Camera cam;
    float timeElapsed;
    public float lerpDuration;
    public float desiredSize;
    private bool cameraTrigger;
    private bool timeEnd;
    public GameObject TimeManager;
    Vector3 startPos;
    Vector3 endPos;

    // Start is called before the first frame update
    void Start()
    {
        startPos = new Vector3(0f, 0f, -9.45f);
        endPos = new Vector3(28, 10, -9.45f);
        cam.orthographicSize = 5;
        cameraTrigger = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        TimeCountdown externalTime = TimeManager.GetComponent<TimeCountdown>();
        timeEnd = externalTime.timeEnd;

        if (timeEnd)
        {
            cameraTrigger = true;

        }
        CameraMove();
    }

    private void CameraMove()
    {
        if (cameraTrigger)
        {
            if (timeElapsed < lerpDuration)
            {

                cam.orthographicSize = Mathf.Lerp(5, desiredSize, timeElapsed / lerpDuration);
                cam.transform.position = new Vector3(
                                     Mathf.Lerp(startPos.x, endPos.x, timeElapsed / lerpDuration),
                                     Mathf.Lerp(startPos.y, endPos.y, timeElapsed / lerpDuration),
                                      -9.45f);
                timeElapsed += Time.deltaTime;

            }

        }
        
    }
}
