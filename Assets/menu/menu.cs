using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Cutscene");
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    void Update()
    {


        if (Input.GetKey("escape"))  
        {
            Application.Quit();  
        }

    }
}
