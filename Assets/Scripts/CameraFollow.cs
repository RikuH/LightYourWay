using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 offset = new Vector3(0, 8,-8);

    void LateUpdate()
    {
        this.transform.position = target.position + offset;
    }
}
