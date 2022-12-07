using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SpriteChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] spriteArray;

    public int randomizer;
    public int actionIntervalOne;
    public int actionIntervalTwo;
    public float timeforturns;

    public bool isLooking;
    public bool isChecking;
    public bool isBase;
    public bool randomizerRan;

    public GameObject player;
    Rigidbody2D playerRb;
    public float playerVel;

    public GameObject careful;
    public GameObject caught;

    
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        actionIntervalOne = 2;
        actionIntervalTwo = 4;
        isLooking = false;
        isChecking = false;
        isBase = true;
        randomizerRan = false;
        playerRb = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timeforturns += Time.deltaTime;

        if (isBase)
        {
            spriteRenderer.sprite = spriteArray[0];
            careful.SetActive(false);
            caught.SetActive(false);
        }
        if (isChecking)
        {
            spriteRenderer.sprite = spriteArray[1];
            careful.SetActive(true);
        }

        if (isLooking)
        {
            careful.SetActive(false);
            spriteRenderer.sprite = spriteArray[2];
            playerVel = playerRb.velocity.x;
            if (playerVel >= 1)
            {
                caught.SetActive(true);
            }
            

        }

        if (timeforturns >= actionIntervalOne)
        {
            isChecking = true;
            isBase = false;
        }

        if (timeforturns >= actionIntervalTwo)
        {
            if (!randomizerRan)
            {
                randomizerRan = true;
                randomizer = Random.Range(1, 3);
                if (randomizer == 2)
                {
                    isChecking = false;
                    isLooking = true;
                } else
                {
                    isChecking = false;
                    isLooking = false;
                }
            } 
 
        }

        if (timeforturns >= 6)
        {
            isChecking = false;
            isLooking = false;
            isBase = true;
            timeforturns = 0;
            randomizerRan = false;
        }

        
    }
}
