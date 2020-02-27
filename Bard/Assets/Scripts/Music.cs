using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour {
    
    [SerializeField]
    private float delay = 2.8f;
    AudioSource myAudio;
    public AudioClip audioClip;
    void Start()
    {
        
        myAudio = GetComponent<AudioSource>();
        Invoke("playSound", delay);
    }

    void playSound()
    {
        myAudio.PlayOneShot(audioClip);
    }
}
