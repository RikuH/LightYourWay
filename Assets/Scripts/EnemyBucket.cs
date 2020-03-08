using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyBucket : MonoBehaviour
{
    public GameObject playerRadar;
    public GameObject player;
    Vector3 startPosition;
    NavMeshAgent agent;
    public ParticleSystem water;

    private void Awake()
    {
        
    }
    void Start()
    {
        startPosition = this.transform.position;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(startPosition.position);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            //agent.Warp(player.transform.position);
            agent.SetDestination(player.transform.position);
            water.Play();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            agent.SetDestination(startPosition);
            water.Stop();
        }
    }
}
