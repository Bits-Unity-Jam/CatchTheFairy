using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windCollider : MonoBehaviour
{
    //GameObject player;
    private Rigidbody2D playerRigitbody;


    void Start()
    {
        playerRigitbody = GetComponent<Rigidbody2D>();
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "WindArea")
    //    {
    //        //playerRigitbody.angularDrag = 3f;
    //        //playerRigitbody.drag = 1;
    //        playerRigitbody.gravityScale = 0.7f;
    //    }
    //}

    private void OnTriggerStay2D(Collider2D collision)
    {
        playerRigitbody.AddForce(transform.up * 1.17f);
        playerRigitbody.gravityScale = 0.7f;
    }
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (collision.gameObject.tag == "WindArea")
    //    {
    //        playerRigitbody.angularDrag = 0;
    //        playerRigitbody.drag = 0.05f;
    //        playerRigitbody.gravityScale = 1f;
    //    }
    //}

    void Update()
    {

    }
}
