using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAnim : MonoBehaviour
{
    private Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveY = rb.velocity.y;

        //animator.SetFloat("x", moveX);
        animator.SetFloat("y", moveY);

        // Flip sprite based on direction
        /*if (moveY < 0)
        {
            sr.flipX = true;
            animator.SetBool("Flip", true);
        }
        else if (moveY > 0)
        {
            sr.flipX = false;
            animator.SetBool("Flip", false);
        }*/
    }


}
