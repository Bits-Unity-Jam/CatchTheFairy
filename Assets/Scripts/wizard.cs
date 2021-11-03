using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wizard : MonoBehaviour
{
    [SerializeField] private Animator animator;
    bool isStarted;
    [SerializeField] private Animator Fader;
    bool isCutsceneEnded;
    bool isGameStarted;

    [SerializeField] private Animator camAnim;
    private void Start()
    {
        animator = GetComponent<Animator>();

        isStarted = false;
        isCutsceneEnded = false;
        isGameStarted = false;
    }

    private void FixedUpdate()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.anyKey) && isStarted != true)
        {
            animator.SetBool("IsStarted", true);
            isStarted = true;

            Invoke(nameof(Fader1), 2f);

            //Invoke(nameof(Droped), 2.7f);

            camAnim.SetBool("cutscene1", true);

            IsStartedFalse();
        }

        //Invoke(nameof(Falsed), 5f);

    }
    public void IsStartedFalse()
    {

        isStarted = false;
        isCutsceneEnded = false;
        isGameStarted = false;
    }

    public void StartScene()
    {
            animator.SetBool("IsStarted", true);
            isStarted = true;

            Invoke(nameof(Fader1), 2f);

            //Invoke(nameof(Droped), 2.7f);

            camAnim.SetBool("cutscene1", true);
    }

    public void Droped()
    {
        animator.SetBool("IsDroped", true);

        Fader.SetBool("IsCutsceneEnded", true);
    }
    public void Fader1()
    {

        Fader.SetBool("IsCutsceneEnded", true);
    }
    public void Falsed()
    {
        camAnim.SetBool("cutscene1", false);
    }
}
