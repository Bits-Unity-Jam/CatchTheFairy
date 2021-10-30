using UnityEngine;
using UnityEngine.SceneManagement;

public class toSecondLvl : MonoBehaviour
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
        SceneManager.LoadScene(2);
    }
}
