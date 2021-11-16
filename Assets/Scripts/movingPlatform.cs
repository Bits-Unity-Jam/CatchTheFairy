using UnityEngine;

public class movingPlatform : MonoBehaviour
{
    [SerializeField] private float verticalSpeed = 3f;
    [SerializeField] private float horizontalSpeed = 3f;
    private bool moveRight = true;
    private bool moveUp = true;
    [SerializeField] private bool horizontalMove;
    [SerializeField] private bool verticalMove;
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    void Update()
    {
        if (horizontalMove)
        {
            if (transform.position.x >= maxX)
            {
                moveRight = false;
            }
            else if (transform.position.x <= minX)
            {
                moveRight = true;
            }

            if (moveRight)
            {
                transform.position = new Vector2(transform.position.x + horizontalSpeed * Time.deltaTime, transform.position.y);
            }
            else
            {
                transform.position = new Vector2(transform.position.x - horizontalSpeed * Time.deltaTime, transform.position.y);
            }
        }
        
        if (verticalMove)
        {
            if (transform.position.y > maxY)
            {
                moveUp = false;
            }
            else if (transform.position.y < minY)
            {
                moveUp = true;
            }

            if (moveUp)
            {
                transform.position = new Vector2(transform.position.x, transform.position.y + verticalSpeed * Time.deltaTime);
            }
            else
            {
                transform.position = new Vector2(transform.position.x, transform.position.y - verticalSpeed * Time.deltaTime);
            }
        }
    }
}
