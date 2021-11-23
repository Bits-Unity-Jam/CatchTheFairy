
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
    private ParticleSystem _partSys;
    //private Collider2D FairyCollider;

    void Start()
    {
        _partSys = GetComponentInChildren<ParticleSystem>();
        _aud = GetComponent<AudioSource>();
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpots.Length);
        _anim = GetComponent<Animator>();
        //FairyCollider = GetComponent<Collider2D>();
        FaityCounter.RestartCounter();
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
            moveSpots[randomSpot].position,speed*Time.deltaTime);

        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
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
            if ((newCollisionTime - FaityCounter.OldCollisionTime()) > 0.41f)
            {
                //FairyCollider.enabled = false;
                FaityCounter.OldCollisionTime(newCollisionTime);
                _partSys.Play();
                _aud.Play();
                _anim.SetTrigger("Catch");
                Invoke("Died", 0.4f);
            }
        }
    }
    void Died()
    {
        Destroy(gameObject);
        FaityCounter.AddOne();
    }
}
