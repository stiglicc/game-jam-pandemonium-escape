using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSlide : MonoBehaviour
{
    public bool isSliding = false;
    Rigidbody2D rb;
    Animator anima;
    [SerializeField] float slideForce =5f;

    public BoxCollider2D normalColider;
    public BoxCollider2D slideColider;
    
    void Start()
    {
        anima = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.LeftArrow)) {
            leftSlide();
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftShift )&& Input.GetKey(KeyCode.RightArrow)) {
            rightSlide();
        }
    }
    
    private void leftSlide() {
        isSliding = true;
        rb.AddForce(Vector2.left * slideForce, 0);
        anima.SetBool("isSliding", true);
        normalColider.enabled = false;
        slideColider.enabled = true;

        StartCoroutine("stopSlide");
    }
    private void rightSlide() {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.right * slideForce, 0);
        isSliding = true;
        anima.SetBool("isSliding", true);
        normalColider.enabled = false;
        slideColider.enabled = true;

        StartCoroutine("stopSlide");
    }
    IEnumerator stopSlide() {
        yield return new WaitForSeconds(0.4f);
        anima.SetBool("isSliding", false);
        normalColider.enabled = true;
        slideColider.enabled = false;
        isSliding = false;
    }
    
    
    
}
