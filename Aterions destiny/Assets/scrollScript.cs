using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollScript : MonoBehaviour
{
    public GameObject scroll_UI;
    bool isReading;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player"){
            activateUI();
            Destroy(gameObject);
            Debug.Log("SCROLL ACTIVATE");
        }
    }
    void Start()
    {

    }

    void Update()
    {
        
    }
    public void activateUI()//scroll item open
    {
        isReading = true;
        scroll_UI.SetActive(true);   
    }
    public void closeUI() //scroll item close
    {
        scroll_UI.SetActive(false);
        isReading = false; 
    }
}
