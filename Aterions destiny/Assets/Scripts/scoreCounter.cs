using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class diamondCounter : MonoBehaviour
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
        if (counterText.text != collectable2.totalDiamonds.ToString()){
            counterText.text = collectable2.totalDiamonds.ToString();
        }
    }
}
