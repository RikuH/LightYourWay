using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketHarmer : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //DEAD
        if (other.tag == "Player")
        {
            Debug.Log("DEAD");
        }
    }
}
