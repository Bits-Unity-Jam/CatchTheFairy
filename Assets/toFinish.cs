using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toFinish : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke(nameof(NextLevel), 0.7f);
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(5);
    }
}
