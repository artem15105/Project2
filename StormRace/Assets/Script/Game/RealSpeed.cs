using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RealSpeed : MonoBehaviour
{
    public Rigidbody MainCarOb = null;// this car 
    public Text RealSpeedCount;// real this speed
    static public int GlobalSpeed = 0;// static скороcnm

    void Start()
    {
        
    }

   
    void Update()
    {
        RealSpeedCount.text = $"{(int)(Drive.realSpeed / 3)} км/ч";//деление скорости на 3 , так как без деления очень большая
        GlobalSpeed = (int) Drive.realSpeed / 3;//назначение глобали
        //Debug.Log(RealSpeedCount.text);
    }
}
