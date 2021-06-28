using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Data : MonoBehaviour
{
    static public  bool statusDelete = false;
    public Text text; 
    static public  int carSelect = 121;
    public bool status = true;
    void Start()
    {
       
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (statusDelete)
        {
            Destroy(gameObject);
            statusDelete = false;
        }
        if (SceneManager.GetActiveScene().name == "Game" || SceneManager.GetActiveScene().name == "game")
        {
            status = false;
        }
        else
        {
            status = true;
        }

        if (status)
        {
            carSelect = Int32.Parse(text.text);
        }
            

        
    }
}
