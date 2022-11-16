using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public GameObject targetObject;

    static MouseManager instance;

    public static MouseManager Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new MouseManager();
            }

            return instance;
        }
    }


    public void DragByTheMouse(GameObject target, Vector3 gap)
    {
        Vector3 screenPos = Camera.main.WorldToScreenPoint(target.transform.position);
        Vector3 offset = Input.mousePosition - screenPos;
        //Debug.Log("Test" + (offset + Input.mousePosition));
        target.transform.position = Camera.main.ScreenToWorldPoint(screenPos + offset + gap);
        target.transform.position += Vector3.forward * 10;
    }
}
