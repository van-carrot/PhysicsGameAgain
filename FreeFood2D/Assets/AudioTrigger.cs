using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    public AudioClip ObjectSounds_1;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void onMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.enabled = true;
            if (!audioSource.isPlaying)
            {
                audioSource.clip = ObjectSounds_1;
                audioSource.Play();
            }
        }
    }
}
