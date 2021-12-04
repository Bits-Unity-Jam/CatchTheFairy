using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerBall : MonoBehaviour
{
    public static float _timeToSpawn;
    [SerializeField] private GameObject _energyBall;
    private void Start()
    {
        StartCoroutine(Spawner());
    }


    IEnumerator Spawner()
    {
        while (true)
        {
            Instantiate(_energyBall, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(_timeToSpawn);
        }

    }
}
