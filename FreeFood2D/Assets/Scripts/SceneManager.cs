using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public GameObject fungusM;
    private void Start()
    {
        fungusM = GameObject.Find("FungusManager");
        fungusM.SetActive(false);
    }
}
