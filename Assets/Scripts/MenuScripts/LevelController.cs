using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public static LevelController instance = null;
    int currentSceneIndex;
    int levelComplete;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelComplete = PlayerPrefs.GetInt("LevelComplete");

    }

    public void isEndGame()
    {
        if (currentSceneIndex == SceneManager.sceneCountInBuildSettings-1)//кількість сцен
        {
            Invoke("LoadMainMenu", 1f);
        }
        else
        {
            if (levelComplete < currentSceneIndex)
            {
                PlayerPrefs.SetInt("LevelComplete", currentSceneIndex);
            }
            Invoke("NextLevel", 1f);
        }
    }

    void NextLevel()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    void LoadMainMenu()
    {
        SceneManager.LoadScene("New Main menu");
    }
}
