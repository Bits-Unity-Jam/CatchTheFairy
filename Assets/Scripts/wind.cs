
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

# region not working!!1!
//public class wind : MonoBehaviour
//{

//    PlayerController playerController;
//    Rigidbody2D playerRigidbody;

//    // Start is called before the first frame update
//    void Start()
//    {

//        //playerController = PlayerController._playerInstance;

//        //playerRigidbody = playerController._rb;
//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        //if (collision.gameObject.tag == "Player");
//        //{
//        //    playerController = PlayerController._playerInstance;
//        //    playerRigidbody = playerController._rb;
//        //}
//        if (playerRigidbody = null)
//        {
//            playerRigidbody = collision.GetComponent<Rigidbody2D>();
//        }
//    }

//    private void OnTriggerStay2D(Collider2D collision)
//    {


//        if (collision.gameObject.tag == "Player")
//        {
//            if ((collision.transform.rotation.z > 0.15 && collision.transform.rotation.z < 0.85) || (collision.transform.rotation.z < -0.15 && collision.transform.rotation.z > -0.85))
//            {
//                playerRigidbody.AddForce(Vector2.up * 3.21f);
//                //playerRigitbody.AddForce(transform.up * 1.01f);
//                playerRigidbody.gravityScale = 0.87f;
//            }
//            else
//            {
//                playerRigidbody.angularDrag = 0;
//                playerRigidbody.drag = 0.05f;
//                playerRigidbody.gravityScale = 1f;
//            }
//        }
//    }

//    private void OnTriggerExit2D(Collider2D collision)
//    {
//        if (collision.gameObject.tag == "Player")
//        {
//            playerRigidbody.angularDrag = 0;
//            playerRigidbody.drag = 0.05f;
//            playerRigidbody.gravityScale = 1f;
//        }
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (playerController == null)
//        {
//            print("vse pizda");
//        }
//        if (playerRigidbody == null)
//        {
//            print("vse pizda snova");
//        }
//    }
//}
#endregion
