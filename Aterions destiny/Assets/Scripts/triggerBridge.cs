using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerBridge : MonoBehaviour
{
    public GameObject firstBridge;
    public GameObject secondBridge;
    //a high ranking Roman general in command of multiple Roman legions who served under the Roman Emperor Marcus Aurelius in his Twelve Year Campaign against the barbarians in Germania.F
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player"){
            firstBridge.transform.Rotate(0, 0, -75);
            secondBridge.transform.Rotate(0, 0, 75);
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
