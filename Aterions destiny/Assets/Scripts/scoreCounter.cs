using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreCounter : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    
    
    void Start()
    {
        //counterText = GetComponent<Text>();
    }
    void Update()
    {
        textUpdater();
    }
    private void textUpdater() {
        if (counterText.text != collectable.totalCoins.ToString()){
            counterText.text = collectable.totalCoins.ToString();
        }
    }
}
