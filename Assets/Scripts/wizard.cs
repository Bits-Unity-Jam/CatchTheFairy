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
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isStarted != true)
        {
            animator.SetBool("IsStarted", true);
            isStarted = true;

            Invoke(nameof(Fader1), 2f);

            //Invoke(nameof(Droped), 2.7f);

            camAnim.SetBool("cutscene1", true);

        }

        //Invoke(nameof(Falsed), 5f);

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
