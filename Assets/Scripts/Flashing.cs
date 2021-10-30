using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing : MonoBehaviour
{
    private ParticleSystem _partical;
    private void Start()
    {
        _partical = GetComponentInChildren<ParticleSystem>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
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
