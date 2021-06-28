using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{

     static public string DopScore = null;//статичстическое значение оочков
     public Text score;//вынутренее
   
    void Start()
    {
        
        score.text = $"0";
    }

    void FixedUpdate()
    {
        if(RealSpeed.GlobalSpeed > 60 && Restart.statusCar)//когда скорость выше 60км и машина жива прибавляет 1 в сек 
        {
          
            score.text = $"{Int32.Parse(score.text) + 1}";
        }
        DopScore = score.text;
    }
}
