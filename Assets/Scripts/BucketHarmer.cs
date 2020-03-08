using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketHarmer : MonoBehaviour
{
    public AudioClip death;
    public PlayerMove playerStuff;
    private void OnTriggerEnter(Collider other)
    {
        //DEAD
        if (other.tag == "Player")
        {
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            audio.clip = death;

            playerStuff.isDead = true;
        }
    }
}
