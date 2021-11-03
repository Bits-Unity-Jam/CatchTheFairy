using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartLvl1 : MonoBehaviour
{
    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            SceneManager.LoadScene("Level 1");
        }
    }

    public void RestartButton()
    {
        SceneManager.LoadScene("Level 1");
    }
}
