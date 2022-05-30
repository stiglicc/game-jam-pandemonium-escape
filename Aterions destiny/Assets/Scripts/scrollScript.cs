using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollScript : MonoBehaviour
{
    public GameObject scroll_UI;
    public AudioSource audioS;
    
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player"){
            activateUI();
            if (!audioS.isPlaying){
                audioS.Play();
            }
           // Destroy(gameObject);
            Debug.Log("SCROLL ACTIVATE");
        }
    }
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)){
            closeUI();
        }
    }
    public void activateUI()//scroll item open
    {
        scroll_UI.SetActive(true);
    }
    public void closeUI() //scroll item close
    {
        scroll_UI.SetActive(false);
        Destroy(gameObject);
        Debug.Log("SCROLL CLOSED");
        audioS.Stop();
    }
}
