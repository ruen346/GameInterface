using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound : MonoBehaviour
{
    public AudioClip background_music;
    public AudioClip sandman_music;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        //To play backround sound 
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        audioSource.clip = background_music;
        audioSource.Play();

        //To play sandman sound 
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }
        audioSource.clip = sandman_music;
        audioSource.Play();
    }
}
