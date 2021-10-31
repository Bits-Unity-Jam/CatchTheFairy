using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing : MonoBehaviour
{
    private ParticleSystem _partical;
    private AudioSource _aud;
    private void Start()
    {
        _aud = GetComponent<AudioSource>();
        _partical = GetComponentInChildren<ParticleSystem>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _aud.Play();
            _partical.Play();
            collision.gameObject.GetComponent<PlayerController>().maxSpeed = 15;
            Invoke("Dead", 0.5f);
        }
    }
    void Dead()
    {
        Destroy(gameObject);
    }
}
