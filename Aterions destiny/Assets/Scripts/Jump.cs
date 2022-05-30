using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public Rigidbody2D rb;
    bool isGrounded;
    Animator anima;
    public float jumpForce;
    public AudioSource audioS;
    public AudioClip jumpSound;
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
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            anima.SetBool("isJumping", true);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isGrounded = false;
            audioS.PlayOneShot(jumpSound);
        } else anima.SetBool("isJumping", false); 
        
        
    }
    
}