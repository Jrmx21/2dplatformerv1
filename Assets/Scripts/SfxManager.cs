using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxManager : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip pickupSfx; // Clip de sonido para el ítem recogido

    
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySfx(AudioClip sfx)
    {
        audioSource.PlayOneShot(sfx);
    }

    public void PlayPickupSfx()
    {
        PlaySfx(pickupSfx);
    }
}
