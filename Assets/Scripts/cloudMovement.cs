using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMovement : MonoBehaviour
{
    private bool dirRight = true;
    public bool vertical = false;
    public float speed = 2.0f;
    public float pos1;
    public float pos2;
    public AudioClip death;

    void Update()
    {
        if (vertical == false)
        {

            if (dirRight)
                transform.Translate(Vector2.right * speed * Time.deltaTime);
            else
                transform.Translate(-Vector2.right * speed * Time.deltaTime);

            if (transform.position.x >= pos1)
            {
                Debug.Log(dirRight);
                dirRight = false;
            }

            if (transform.position.x <= pos2)
            {
                dirRight = true;
            }
        }

        else
        {
            if (dirRight)
                transform.Translate(Vector3.forward * speed * Time.deltaTime);
            else
                transform.Translate(-Vector3.forward * speed * Time.deltaTime);

            if (transform.position.z >= pos1)
            {
                dirRight = false;
            }

            if (transform.position.z <= pos2)
            {
                dirRight = true;
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        //DEAD
        if(other.tag == "Player")
        {
            Debug.Log("DEAD");
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            audio.clip = death;
        }
    }
}
