using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public float InputeValue { get; private set; }

    private void Update()
    {
        InputeValue = Input.GetAxis("Horizontal");
    }
}
