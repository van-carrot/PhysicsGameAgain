using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public void OnClickStart()
    {
        this.gameObject.SetActive(false);
    }
}
