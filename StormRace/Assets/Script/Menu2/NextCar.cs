using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NextCar : MonoBehaviour
{
    public Text select;//�����, ������� ������ ������ ��� ���������� 1 �����, ��������� �� ������ ������ ������
    

    public List<GameObject> ArrayCars = new List<GameObject>();//array cars 
   



    public void NextVariable()//����� ������������ ��� �������� ArrayCars, � ��������� �� �� ��� X �� -53,
                              //� ��� �� ������������ select.text
    {
        if (Int32.Parse(select.text) < ArrayCars.Count)
        {
            foreach (GameObject ob in ArrayCars)
            {
                ob.transform.position += new Vector3(-53, 0, 0);
            }

            select.text = $"{Int32.Parse(select.text) + 1}";
        }
        

    }
    public void BackVariable()//����� ������������ ��� �������� ArrayCars, � ��������� �� �� ��� X �� +53
                              //� ��� �� ������������ select.text
    {

        if (Int32.Parse(select.text) > 1)
        {
            foreach(GameObject ob in ArrayCars)
            {
                ob.transform.position += new Vector3(53, 0, 0);
            }
            
            select.text = $"{Int32.Parse(select.text) - 1}";
        }
        

    }
    void Start()
    {
       
    }

    
    void Update()
    {
        
    }
}
