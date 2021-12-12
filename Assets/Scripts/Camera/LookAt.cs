using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    [SerializeField]private Transform _target;
    [SerializeField] private float smoothSpeed = 0.125f;
    [SerializeField] private Vector3 _offset;
    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void LateUpdate()
    {
        Vector3 desirePosition = _target.position + _offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position,desirePosition,smoothSpeed);
        transform.position = smoothedPosition;
    }
}
