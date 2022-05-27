using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stickCollider : MonoBehaviour
{
    [SerializeField] GameObject player;
    bool isSticked;
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            isSticked = true;
        }
    }

    private void Update()
    {
        if (isSticked){
            player.transform.position = transform.position;
        }
        unstick();
    }
    
    private void unstick() {
        float moves = Input.GetAxis("Horizontal");
        if (moves != 0) {
            isSticked = false;
            player.transform.position = player.transform.position;
        }
    }
}
    
   

