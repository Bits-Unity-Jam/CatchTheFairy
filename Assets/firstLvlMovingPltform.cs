using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstLvlMovingPltform : MonoBehaviour
{
    float dX;
    float speed = 0.3f;

    bool moveUp = true;


    void Update()
    {
        if (transform.position.y >= 6.28)
        {
            moveUp = false;
        }
        else if (transform.position.y <= 4.94)
        {
            moveUp = true;
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
