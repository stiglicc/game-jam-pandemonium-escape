using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    public static int totalCoins = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player") {
            AddCoin();
            Destroy(gameObject);
        }
        Debug.Log("You now have " + collectable.totalCoins + " coins.");
    }
    private void AddCoin()
    {
        totalCoins++;
    }

    void Start()
    {

    }


    void Update()
    {

    }
}
