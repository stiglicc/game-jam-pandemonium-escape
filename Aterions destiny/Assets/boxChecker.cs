using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxChecker : MonoBehaviour
{
    [SerializeField] GameObject spawnObject;
    [SerializeField] GameObject wallMove;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Box")
        {
            wallMove.transform.Translate(0, -5.091f, 0);
           // Instantiate(spawnObject, new Vector2(34, 1),Quaternion.identity);
            Debug.Log("Uspesno stavljena kutija");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
