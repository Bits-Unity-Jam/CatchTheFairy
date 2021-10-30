using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnColliPlatform : MonoBehaviour
{
    [SerializeField]private Rigidbody2D _rb;
    [SerializeField] private float _forceUP;
    [SerializeField] private Transform _tr;

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            Debug.Log("Collision");
            _rb.AddForce(new Vector2(_tr.position.x - transform.position.x, _tr.position.y - transform.position.y) * _forceUP, ForceMode2D.Impulse);
            //_rb.velocity = new Vector2(_tr.position.x - transform.position.x, _tr.position.x - transform.position.y) * _forceUP;
        }
    }
}

