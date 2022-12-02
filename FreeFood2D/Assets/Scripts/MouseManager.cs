using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public GameObject targetObject;

    public static MouseManager Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
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
