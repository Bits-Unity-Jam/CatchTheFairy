using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointedSpawnSachock : MonoBehaviour
{
    [SerializeField] private GameObject _sachok;

    private void Start()
    {
        Instantiate(_sachok, transform.position, Quaternion.identity);
    }
}
