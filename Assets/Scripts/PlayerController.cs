using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    public float maxSpeed;
    public float direction;
    public float normalDirection = 1;

    private Vector3 _rotation;
    private Rigidbody2D _rb;
    [HideInInspector]public Animator _anim;
    public ParticleSystem _energyPartical;
    
    void Start()
    {
        direction = 0f;
        _energyPartical = GameObject.FindGameObjectWithTag("Partical")?.GetComponent<ParticleSystem>();
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();
    }
    void Update()
    {
       
        _rotation = new Vector3(0, 0, direction * -_rotationSpeed);
        //_rotation = new Vector3(0, 0, Input.GetAxis("Horizontal") * -_rotationSpeed);
        transform.Rotate(_rotation);
    }

    public void OnTurnLeftButtonDown()
    {
        if (direction >= 0f)
        {
            direction = -normalDirection;
        }
    }

    public void OnTurnRightButtonDown()
    {
        if (direction <= 0f)
        {
            direction = normalDirection;
        }
    }

    public void OnButtonUp()
    {
        direction = 0f;
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

