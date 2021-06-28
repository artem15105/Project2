using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{
    public Text MoneyCount; 
    void Start()
    {
       
    }

    
    void Update()
    {
        MoneyCount.text = $"{PlayerPrefs.GetInt("Count")}";//real state balance
    }
}
