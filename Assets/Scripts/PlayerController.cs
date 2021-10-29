using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    private Vector3 _rotation;
    private Rigidbody2D _rb;
    [SerializeField] private float _forceUP;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        _rotation = new Vector3(0, 0, Input.GetAxis("Horizontal") * -_rotationSpeed);
    }
    private void FixedUpdate()
    {
        if (_rotation.z == 0)
        {
            _rb.angularVelocity = 0f;
        }

        transform.Rotate(_rotation);

    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            _rb.AddForce(Vector2.up * _forceUP,ForceMode2D.Impulse);
        }
    }

}

