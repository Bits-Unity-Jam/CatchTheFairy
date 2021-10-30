using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    float dX;
    float speed = 3f;

    bool moveRight = true;


    void Update()
    {
        if (transform.position.x >= 36.82)
        {
            moveRight = false;
        }
        else if(transform.position.x <= 26.78)
        {
            moveRight = true;
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
