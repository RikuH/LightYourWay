using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketHarmer : MonoBehaviour
{
    public AudioClip death;
    private void OnTriggerEnter(Collider other)
    {
        //DEAD
        if (other.tag == "Player")
        {
                AudioSource audio = GetComponent<AudioSource>();

                audio.Play();
                audio.clip = death;
        }
    }
}
