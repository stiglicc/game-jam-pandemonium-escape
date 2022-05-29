using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable2 : MonoBehaviour
{
    public static int totalDiamonds = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            AddCoinn();
            Destroy(gameObject);
        }
        Debug.Log("You now have " + collectable2.totalDiamonds + " coins.");
    }
    private void AddCoinn(){
        totalDiamonds++;
    }

    void Start()
    {

    }


    void Update()
    {

    }
}
