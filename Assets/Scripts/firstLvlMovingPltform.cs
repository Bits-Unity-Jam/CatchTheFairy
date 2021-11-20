using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstLvlMovingPltform : MonoBehaviour
{
    float dX;
    float speed = 0.3f;
    [SerializeField] private float moveTime;

    bool moveUp = true;
    float startMoveTime = Time.time;


    void Update()
    {

        float deltaT = (Time.time - startMoveTime);
        if (deltaT <= moveTime)
        {
            moveUp = false;
        }
        else if (deltaT > moveTime && deltaT <= moveTime * 2)
        {
            moveUp = true;
        }
        else
        {
            startMoveTime = Time.time;
        }

        if (moveUp)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed * Time.deltaTime);
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed * Time.deltaTime);
        }
    }
}
