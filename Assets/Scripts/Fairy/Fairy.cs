using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Fairy : MonoBehaviour
{
    [SerializeField]
    private Transform[] _flySpots;

    [SerializeField]
    private float _flySpeed;

    public UnityEvent CatchEvent;

    private int _randomSpotNumber;

    private void Start()
    {
        _randomSpotNumber = GiveRandomSpotNumber();
    }
    private void Update()
    {
        Fly();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<Sachock>()!=null)
        {
            FairyCounter.AddOne();
            CatchEvent?.Invoke();//Dead anim;partical;sound
        }
    }
    private void Fly()
    {
        transform.position = Vector2.MoveTowards(transform.position,
            _flySpots[_randomSpotNumber].position, _flySpeed * Time.deltaTime);

        if (Vector2.Distance(transform.position, _flySpots[_randomSpotNumber].position) < 0.2f)
        {
            _randomSpotNumber = GiveRandomSpotNumber();
        }
    }

    private int GiveRandomSpotNumber()=> Random.Range(0, _flySpots.Length);

}
