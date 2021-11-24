using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nextlevel : MonoBehaviour
{
    private LevelController _levelController;
    private void Start()
    {
        _levelController =LevelController.instance;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _levelController.isEndGame();
        }
        
    }
}
