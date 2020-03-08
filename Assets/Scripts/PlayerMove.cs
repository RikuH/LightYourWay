using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[DisallowMultipleComponent]
[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMove : MonoBehaviour
{
    private Vector3 targetPosition;
    const int Left_Mouse_Button = 0;
    NavMeshAgent agent;
    Rigidbody rb;

    public bool isDead = false;
    Animator anim;
    public bool inputDisabled = false;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        targetPosition = this.transform.position;
    }

    void Update()
    {
        if (!inputDisabled)
        {
            if (Input.GetMouseButton(0))
            {
                setTargetPosition();
                movePlayer();
            }

            if (isDead)
            {
                inputDisabled = true;
                anim.SetBool("isDead", true);
            }
        }
    }

    void setTargetPosition()
    {
        Plane plane = new Plane(Vector3.up, this.transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float point = 0;

        if(plane.Raycast(ray, out point))
        {
            targetPosition = ray.GetPoint(point);
        }
    }

    void movePlayer()
    {
        agent.SetDestination(targetPosition);

    }
}
