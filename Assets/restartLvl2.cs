using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartLvl2 : MonoBehaviour
{

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            SceneManager.LoadScene(3);
        }

    }
}
