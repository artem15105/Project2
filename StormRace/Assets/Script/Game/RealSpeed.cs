using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class RealSpeed : MonoBehaviour
{
    public Rigidbody MainCarOb = null;// this car 
    public Text RealSpeedCount;// real this speed
    static public int GlobalSpeed = 0;// static �����cnm

    void Start()
    {
        
    }

   
    void Update()
    {
        RealSpeedCount.text = $"{(int)(Drive.realSpeed / 3)} ��/�";//������� �������� �� 3 , ��� ��� ��� ������� ����� �������
        GlobalSpeed = (int) Drive.realSpeed / 3;//���������� �������
        //Debug.Log(RealSpeedCount.text);
    }
}
