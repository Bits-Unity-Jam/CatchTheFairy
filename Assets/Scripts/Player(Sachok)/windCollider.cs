using System;
using UnityEngine;

public class windCollider : MonoBehaviour
{
    //GameObject player;
    private Rigidbody2D playerRigitbody;
    private Transform playerTransform;
    //bool IsWind;
    [SerializeField] private float forceSvale = 3.21f;
    [SerializeField] private float gravityMultiple = 0.81f;

    //float angle;

    void Start()
    {
        playerTransform = GetComponent<Transform>();
        playerRigitbody = GetComponent<Rigidbody2D>();
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    //if (collision.gameObject.tag == "WindArea")
    //    //{
    //    //    //playerRigitbody.angularDrag = 3f;
    //    //    //playerRigitbody.drag = 1;
    //    //    playerRigitbody.gravityScale = 0.7f;
    //    //}
    //}

    private void OnTriggerStay2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "WindArea")
        {

            if ((transform.rotation.z > 0.15 && transform.rotation.z < 0.85) || (transform.rotation.z < -0.15 && transform.rotation.z > -0.85))
            {
                playerRigitbody.AddForce(Vector2.up * forceSvale);
                //playerRigitbody.AddForce(transform.up * 1.01f);
                playerRigitbody.gravityScale = gravityMultiple;
            }
            else
            {
                playerRigitbody.angularDrag = 0;
                playerRigitbody.drag = 0.05f;
                playerRigitbody.gravityScale = 1f;
            }
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "WindArea")
        {
            playerRigitbody.angularDrag = 0;
            playerRigitbody.drag = 0.05f;
            playerRigitbody.gravityScale = 1f;
        }
    }

    //void Update()
    //{
    //    angle = transform.rotation.z;
    //    print(angle);
    //}
}
