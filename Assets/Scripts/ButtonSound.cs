using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonSound : MonoBehaviour
{
    
  
    public AudioSource audioSource;
    public AudioClip hoverAudio;

    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        audioSource.clip = hoverAudio;
        audioSource.playOnAwake = false;


    }

    
    public void HoverSound () {
        audioSource.PlayOneShot (hoverAudio);
    }
}
