using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationscript : MonoBehaviour
{
    public Animator player_animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)  ||  Input.GetKey(KeyCode.W)  ||  Input.GetKey(KeyCode.Space))
        {
            player_animator.SetTrigger("jump");
        }
        if (Input.GetKey(KeyCode.RightArrow)  ||  Input.GetKey(KeyCode.LeftArrow)  ||  Input.GetKey(KeyCode.D)  ||  Input.GetKey(KeyCode.A))
        {
            player_animator.SetTrigger("run");
        }
        else
        {
            player_animator.SetTrigger("idle");
        }
    }
}
