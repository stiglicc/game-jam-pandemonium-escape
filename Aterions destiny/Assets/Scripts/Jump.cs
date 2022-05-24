using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;
    public float buttonTime = 0.5f;
    public float jumpHeight = 5;
    public float cancelRate = 100;
    float jumpTime;
    bool jumping;
    bool jumpCancelled;
    bool isGrounded;
    Animator anima;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Ground") {
            isGrounded = true;
            Debug.Log("Na zemlji");
            
        } else  Debug.Log("X"); 
    }
    private void Start()
    {
        isGrounded = true;
        anima = GetComponent<Animator>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            anima.SetBool("isJumping", true);
            float jumpForce = Mathf.Sqrt(jumpHeight * -1.5f * (Physics2D.gravity.y * rb.gravityScale));
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
            jumping = true;
            jumpCancelled = false;
            jumpTime = 0;
        } else anima.SetBool("isJumping", false);
        if (jumping) {
            jumpTime += Time.deltaTime;
            if (Input.GetKeyUp(KeyCode.Space)) {
                jumpCancelled = true;
            }
            if (jumpTime > buttonTime) {
                jumping = false;
            }
        }
    }
    private void FixedUpdate()
    {
        if (jumpCancelled && jumping && rb.velocity.y > 0) {
            rb.velocity = Vector2.down * cancelRate;
        }
    }
}