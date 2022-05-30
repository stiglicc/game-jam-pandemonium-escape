using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveHope : MonoBehaviour
{
    [SerializeField] float hopeSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(hopeSpeed, 0, 0);
    }
}
