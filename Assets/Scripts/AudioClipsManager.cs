using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioClipsManager : MonoBehaviour {

    public AudioClip errorClip;
    public AudioClip goodClip;
    public AudioClip typeWriter;

    private float pitch = 0;


    public void PlayGoodSound()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        SetNeutralPitch();
        aSource.PlayOneShot(goodClip, 1f);
    }
    public void PlayErrorSound()
    {
        AudioSource aSource = gameObject.GetComponent<AudioSource>();
        SetNeutralPitch();
        aSource.PlayOneShot(errorClip, 1f);
    }

    public void PlayTypeWriterSound()
    {
        AudioSource aSource = GetComponent<AudioSource>();
        ChangeTypeWriterPitch();
        aSource.PlayOneShot(typeWriter, 1f);
    }

    private void ChangeTypeWriterPitch()
    {
        float randomPitch = Random.Range(-3f, 3f);
    }

    private void SetNeutralPitch()
    {
        pitch = 1;
    }

}
