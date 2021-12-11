using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BottomSachock : MonoBehaviour
{
    public UnityEvent OnPlatformCollision;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
            OnPlatformCollision?.Invoke();//particals;audio;anim;jump
    }
}

