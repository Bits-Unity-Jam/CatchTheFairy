using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoFrictionPlatforn : MonoBehaviour
{
    [SerializeField] private float _speedAcceleration;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>()!=null)
        {
            PlayerController._playerInstance._rb.AddForce(transform.position * PlayerController._playerInstance.transform.rotation.z * _speedAcceleration, ForceMode2D.Impulse);
        }
    }
}
