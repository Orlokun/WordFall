using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipsManager : MonoBehaviour {

    public AudioClip errorClip;
    public AudioClip goodClip;


    public void PlayGoodSound()
    {
        AudioSource aSource = gameObject.GetComponent<AudioSource>();
        aSource.clip = goodClip;
        aSource.Play();
    }
    public void PlayErrorSound()
    {
        AudioSource aSource = gameObject.GetComponent<AudioSource>();
        aSource.clip = errorClip;
        aSource.Play();
    }

}
