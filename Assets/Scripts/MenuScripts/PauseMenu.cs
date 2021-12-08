using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject _gameUI;
    public static bool GameIsPaused = false;
    //[SerializeField] private GameObject pauseMenuUI;

    private LevelController _levelController;

    void Start()
    {
        _levelController = LevelController.instance;
    }
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Escape))
        //{
        //    if (GameIsPaused)
        //    {
        //        Resume();
        //    }
        //    else
        //    {
        //        Pause();
        //    }
        //}
    }

    //public void GamePause()
    //{
    //    Pause();
    //}
    //private void Start()
    //{
    //    pauseMenuUI.SetActive(false);
    //}
    public void Resume()
    {
        //pauseMenuUI.SetActive(false);
        //Time.timeScale = 1f;
        SceneManager.UnloadSceneAsync(7);
        _gameUI?.SetActive(true);
        GameIsPaused = false;
    }

    public void Pause()
    {
        //pauseMenuUI.SetActive(true);
        //Time.timeScale = 0f;
        SceneManager.LoadSceneAsync(7, LoadSceneMode.Additive);
        GameIsPaused = true;
    }
    public void ReStart()
    {
        _levelController.RestartLevel();
    }

    //public void LoadMenu()
    //{
    //    SceneManager.LoadScene("New Main menu");
    //    Time.timeScale = 1f;
    //}

    //public void QuitGame()
    //{
    //    Application.Quit();
    //}
    

}
