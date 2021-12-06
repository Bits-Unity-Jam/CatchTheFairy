using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager instance { get; private set; }
    private bool _shouldLoad;

    private void Awake()
    {
        if (instance!=null)
        {
            print("destor");
            Destroy(gameObject);
        }
        instance = this;
    }
    private void Start()
    {
        _shouldLoad = true;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&& _shouldLoad)
        {
            SceneManager.LoadSceneAsync(7, LoadSceneMode.Additive);
            _shouldLoad = false;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !_shouldLoad)
        {
            SceneManager.UnloadSceneAsync(7);
            _shouldLoad = true;
        }
    }
}
