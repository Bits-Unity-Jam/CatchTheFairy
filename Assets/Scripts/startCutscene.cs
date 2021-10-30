using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startCutscene : MonoBehaviour
{
    

    [SerializeField]private Animator camAnim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            camAnim.SetBool("cutscene1", true);
        }
    }
}
