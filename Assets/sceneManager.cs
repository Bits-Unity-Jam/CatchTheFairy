using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Invoke(nameof(NextLevel), 1.99f);
        }
    }
    public void NextLevel()
    {
        SceneManager.LoadScene("Level 1");
    }
}
