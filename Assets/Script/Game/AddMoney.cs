using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Text.RegularExpressions;

public class AddMoney : MonoBehaviour
{
    public Text DriftPoint;


    public void Add()
    {
        Regex regex = new Regex("[0-9]+");
        Match res = regex.Match(DriftPoint.text);
        

        PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + Int32.Parse(res.Value));
        Debug.Log(PlayerPrefs.GetInt("Money") + Int32.Parse(res.Value));
    }
    public void Update()
    {
        
    }
}
