using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColliPlatform : MonoBehaviour
{
    [SerializeField]private Rigidbody2D _rb;
    [SerializeField] private float _forceUP;
    [SerializeField] private Transform _tr;
    private PlayerController _plContr;
    private AudioSource _aud;
    private ParticleSystem _partic;
    private void Start()
    {
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
            _rb.AddForce(new Vector2(_tr.position.x - transform.position.x, _tr.position.y - transform.position.y) * _forceUP, ForceMode2D.Impulse);
            //_rb.velocity = new Vector2(_tr.position.x - transform.position.x, _tr.position.x - transform.position.y) * _forceUP;
        }
    }
    

}

