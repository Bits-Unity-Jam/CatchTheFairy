using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{

    public float speed;
    private float waitTime;
    public float startWaitTime;
    public Transform[] moveSpots;
    private int randomSpot;
    private Animator _anim;
    private AudioSource _aud;

    void Start()
    {
        _aud = GetComponent<AudioSource>();
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
        _anim = GetComponent<Animator>();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
            moveSpots[randomSpot].position,speed*Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position)< 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                waitTime = startWaitTime;
            }
            else 
            {
                waitTime -= Time.deltaTime;
            }

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            float newCollisionTime = Time.time;
            if ((newCollisionTime - FaityCounter.OldCollisionTime()) > 0.29f)
            {
                FaityCounter.OldCollisionTime(newCollisionTime);
                _aud.Play();
                _anim.SetTrigger("Catch");
                Invoke("Died", 0.23f);
            }
        }
    }
    void Died()
    {
        Destroy(gameObject);
        FaityCounter.AddOne();
    }
}
