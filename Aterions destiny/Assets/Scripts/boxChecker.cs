using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxChecker : MonoBehaviour
{
    [SerializeField] GameObject wallMove;
    
    bool isTriggered;
   // bool isSpawned;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box"){
            isTriggered = true;
            Debug.Log("uspesno");
        }
    }
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered)  {
            move();
        }

    }
    private void move(){
        wallMove.transform.Translate(new Vector2(0, -0.01f));
    }
   
}
