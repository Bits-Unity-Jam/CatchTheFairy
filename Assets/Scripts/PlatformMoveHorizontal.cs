using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveHorizontal : MonoBehaviour
{
    float dX;
    float speed = 3f;
    [SerializeField] private float moveTime;
    bool moveRight = true;
    float startMoveTime = Time.time;


    void Update()
    {
        float deltaT = (Time.time - startMoveTime);
        if (deltaT <= moveTime)
        {
            moveRight = false;
        }
        else if(deltaT > moveTime && deltaT <= moveTime * 2)
        {
            moveRight = true;
        }
        else
        {
            startMoveTime = Time.time;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
}
