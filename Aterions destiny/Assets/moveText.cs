using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveText : MonoBehaviour
{
    [SerializeField] float speedCanvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speedCanvas, 0);
    }
}
