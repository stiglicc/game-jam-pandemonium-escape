using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : MonoBehaviour
{
    public GameObject windedObject;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        windedObject.transform.Translate(new Vector2(-0.01f,0));
    }
}
