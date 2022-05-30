using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    [SerializeField] float rotationAmount;
    [SerializeField] float forwardAmoung;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0, rotationAmount);
        transform.Translate(0, forwardAmoung, 0);
    }
}
