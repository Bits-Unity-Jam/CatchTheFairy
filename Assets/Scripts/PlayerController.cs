using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField]private float maxSpeed = 200f;

    private Vector3 _rotation;
    private Rigidbody2D _rb;
    
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _rotation = new Vector3(0, 0, Input.GetAxis("Horizontal") * -_rotationSpeed);
        transform.Rotate(_rotation);
    }
    private void FixedUpdate()
    {
        _rb.angularVelocity = 0f;
        if (_rb.velocity.magnitude > maxSpeed)
        {
            _rb.velocity = _rb.velocity.normalized * maxSpeed;
        }

    }
    
}

