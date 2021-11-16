using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    //public float maxSpeed;
    private Vector3 _rotation;
    [HideInInspector]public Rigidbody2D _rb;
    [HideInInspector]public Animator _anim;
    public ParticleSystem _PlayerConPartical;
    private SpriteRenderer _spriteRend;
    public static PlayerController _playerInstance { get; private set; }

    private void Awake()
    {
        _playerInstance = this;
    }

    void Start()
    {
        _spriteRend = GetComponentInChildren<SpriteRenderer>();
        //_PlayerConPartical = GetComponentInChildren<ParticleSystem>();
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if (_rb.velocity.x < 0)
        {
            _spriteRend.flipX = true;
        }
        else
        {
            _spriteRend.flipX = false;
        }
    }
    private void FixedUpdate()
    {
        _rotation = new Vector3(0, 0, Input.GetAxis("Horizontal") * -_rotationSpeed);
        transform.Rotate(_rotation);
    }
    
}

