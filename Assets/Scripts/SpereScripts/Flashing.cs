using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashing : MonoBehaviour
{
    private ParticleSystem _partical;
    private AudioSource _aud;
    private ParticleSystem _energyPartical;
    private PlayerController _player;
    [SerializeField] private float _boostSpeed;
    [SerializeField] private float _timeUnBoost; 
    private void Start()
    {
        _aud = GetComponent<AudioSource>();
        _partical = GetComponentInChildren<ParticleSystem>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _player = collision.gameObject.GetComponent<PlayerController>();
            _energyPartical = _player._PlayerConPartical;
            _energyPartical.Play();
            _aud.Play();
            _partical.Play();
            PhysicsOfJump.instanceOnColl._forceUP = _boostSpeed;
            Invoke("Dead", 0.5f);
            Invoke("Timer", _timeUnBoost);
        }
    }
    private void Timer()
    {
        Debug.Log("Unboost");
         UnBoost();
         Destroy(gameObject);
    }
    void Dead()
    {
        Debug.Log("UnActive");
        gameObject.SetActive(false);
    }
    public void UnBoost()
    {
        PhysicsOfJump.instanceOnColl._forceUP = 7;
        _energyPartical.Stop();
    }
}
