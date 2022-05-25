using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed;
    Rigidbody2D rb;
    Animator anima;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anima = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        //movement input
        float moveHorizontal = Input.GetAxis("Horizontal")*moveSpeed*Time.deltaTime;
        rb.velocity = new Vector2(moveHorizontal, rb.velocity.y);

        //player facing direction
        if (moveHorizontal > 0) {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (moveHorizontal < 0) {
            GetComponent<SpriteRenderer>().flipX = true;
        }

        //animation run
        anima.SetBool("isRunning", moveHorizontal != 0);
    } 
}
