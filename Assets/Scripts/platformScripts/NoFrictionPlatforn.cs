using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoFrictionPlatforn : MonoBehaviour
{
    private Quaternion  _RotPlayer;
    [SerializeField] private float _speedAcceleration;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<PlayerController>()!=null)
        {
            _RotPlayer = PlayerController._playerInstance.transform.rotation.normalized;
            PlayerController._playerInstance._rb.AddForce(transform.right * _RotPlayer.z * _speedAcceleration, ForceMode2D.Impulse);
        }
    }
}
