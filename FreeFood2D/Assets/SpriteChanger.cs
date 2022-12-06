using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;
    private int randomizer;
    public int actionInterval;
    public float timeforturn;
    private bool isLooking;

    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        actionInterval = 3;
    }

    // Update is called once per frame
    void Update()
    {
        timeforturn += Time.deltaTime;

        if (timeforturn <= 1)
        {
            spriteRenderer.sprite = spriteArray[0];
        }
        if (timeforturn >= actionInterval)
        {
            randomizer = Random.Range(1, 4);
            if (randomizer == 2)
            {
                spriteRenderer.sprite = spriteArray[1];
                timeforturn = 0;
            }
        }
       
    }
}
