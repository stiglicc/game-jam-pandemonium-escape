using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxChecker : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;
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
       // isSpawned = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isTriggered)  {
            spawnObject_();
        }

    }
    private void spawnObject_()
    {
        Instantiate(spawnObject, new Vector2(-19.50f, -18.50f), Quaternion.identity);       isTriggered = false;
       // isSpawned = true;
    }
   
}
