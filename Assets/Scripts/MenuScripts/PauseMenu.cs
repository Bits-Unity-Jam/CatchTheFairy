using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject _gameUI;
    public static bool GameIsPaused = false;

    private LevelController _levelController;

    void Start()
    {
        _levelController = LevelController.instance;
    }
    
    public void Resume()
    {
        SceneManager.UnloadSceneAsync(7);
        _gameUI?.SetActive(true);
        GameIsPaused = false;
    }

    public void Pause()
    {
        SceneManager.LoadSceneAsync(7, LoadSceneMode.Additive);
        GameIsPaused = true;
    }
    public void ReStart()
    {
        _levelController.RestartLevel();
    }
}
