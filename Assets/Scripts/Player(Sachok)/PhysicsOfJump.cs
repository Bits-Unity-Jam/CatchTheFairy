using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsOfJump : MonoBehaviour
{
    [SerializeField]private Rigidbody2D _rb;
    [HideInInspector]public float _forceUP;
    public float _defaultForceUP { get; private set; } = 7;
    [SerializeField] private Transform _tr;
    private PlayerController _plContr;
    private AudioSource _aud;
    private ParticleSystem _partic;
    public static PhysicsOfJump instanceOnColl;
    private void Awake()
    {
        instanceOnColl = this;
    }
    private void Start()
    {
        _forceUP = _defaultForceUP;
        _partic = GetComponentInChildren<ParticleSystem>();
        _aud = GetComponentInParent<AudioSource>();
        _plContr = GetComponentInParent<PlayerController>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            _partic.Play();
            _aud.Play();
            _plContr._anim.SetTrigger("Bounce");
            _rb.velocity = new Vector3(0, 0,0);
            _rb.AddForce(new Vector2(_tr.position.x - transform.position.x, _tr.position.y - transform.position.y) * _forceUP, ForceMode2D.Impulse);
            //_rb.velocity = new Vector2(_tr.position.x - transform.position.x, _tr.position.x - transform.position.y) * _forceUP;
        }
    }
}

