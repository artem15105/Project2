using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{

     static public string DopScore = null;//��������������� �������� ������
     public Text score;//����������
   
    void Start()
    {
        
        score.text = $"0";
    }

    void FixedUpdate()
    {
        if(RealSpeed.GlobalSpeed > 60 && Restart.statusCar)//����� �������� ���� 60�� � ������ ���� ���������� 1 � ��� 
        {
          
            score.text = $"{Int32.Parse(score.text) + 1}";
        }
        DopScore = score.text;
    }
}
