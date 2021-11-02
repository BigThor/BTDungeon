using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] public Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] public float smoothSpeed = 0.125f;

    private void LateUpdate()
    {
        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}
