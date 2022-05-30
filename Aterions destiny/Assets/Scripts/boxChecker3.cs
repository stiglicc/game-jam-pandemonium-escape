using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxChecker3 : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;

    bool isTriggered;
    bool isSpawned;
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
        if (isTriggered&&!isSpawned)  {
            spawn();
        }

    }
    
    private void spawn() {
        Instantiate(spawnObject,new Vector2(-17.32f, -26.41f),Quaternion.identity);
        isSpawned = true;
    }
   
}
