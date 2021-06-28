using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Variable : MonoBehaviour
//select.text - ��� ����� (�� � ���� string), ������� ������ � ���� ����� ��������� ������ !!!
{
    public int CountCars;    //������� ����� �����

    public Text select;      //����� � ��������� �������,(int)
    public Text Buy;         //����� � �����(int)
    public Text ButtonCenter;//������ �� ������, ��� ��� ������, ��� ������ �0����������� �� ���� ������� �� ������  

    public Dictionary<string, bool> ArrBuyCars = new Dictionary<string, bool>();// ������ � ������� ����� �������� ��� ��������� ������, <��������, ������� ��?>
    public Image Setting;    //��������� ����� ����������
    public Image StartSpeed; //��������� ����� ���������
    public Image MaxSpeed;   //��������� ����� ������������ 

    public void Center()
    {
        
        if (PlayerPrefs.GetInt("car" + select.text) == 1)
        {
            ButtonCenter.text = "������";
        }
        else
        {
            ButtonCenter.text = "������";
        }
    }

    public void Click()
    {
        if (PlayerPrefs.GetInt("car" + select.text) == 1)//���� ������ ������� �� ��� ������� �� ������ ��������� �� ������ �����
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else   //���� ������ �� ������� �� ��� ������� �� ������ ��������� ���������� �� ����� ��� � �������,
               // ���� ���������� �� �������� �, � ��������� �������
        {
            if (PlayerPrefs.GetInt("Count") >= Int32.Parse(Buy.text))
            {
                PlayerPrefs.SetInt("Count", PlayerPrefs.GetInt("Count") - Int32.Parse(Buy.text));
                PlayerPrefs.SetInt("car" + select.text, 1);
            }
        }
    }
    void Start()
    {

        //�������� �������, �� ����: "Car1" => true
        for(int i = 1; i <= CountCars; i++)
        {
            ArrBuyCars.Add($"car{i}", false);
        }
        PlayerPrefs.SetInt("car1", 1);//������ ������ � ���� �������

        /*for(int i = 1; i < ArrBuyCars.Count; i++)
        {
          
            if (PlayerPrefs.GetInt("car" + i) == 1) { ArrBuyCars["car" + 1] = true; };
        }
        foreach (KeyValuePair<string, bool> car in ArrBuyCars)
        {
            if (PlayerPrefs.GetInt(car.Key) == 1) { ArrBuyCars[car.Key] = true; };
        }
        if (PlayerPrefs.GetInt("car2") == 1) { ArrBuyCars["car2"] = true; }; - �������� �����
        */

        
    }


    void Update()
    {
        //Debug.Log(PlayerPrefs.GetInt("car" + select.text)); - �������� �����
        Center();//��� ����� ��������� ��������� ������ �� ������, � ���� ��� ��������� �� ������ � �����
        
        if (Input.GetKey("y"))
        {
            PlayerPrefs.SetInt("Count", PlayerPrefs.GetInt("Count") + 1000);
        }
        if (Input.GetKey("u"))
        {
            PlayerPrefs.DeleteAll();
        }
        if (Input.GetKey("i"))
        {
            PlayerPrefs.SetInt("Count", PlayerPrefs.GetInt("Count") - 1000);
        }
        //�������� ������, ��� ���������� � ��������� �������
       
        //������������ �� ��������� ������ ���������� ��������������� �������������� ��� ���� � ����� ������ �� ������
        if (select.text == "1")
        {
            
            

            Setting.fillAmount = 0.5f;
            StartSpeed.fillAmount = 0.2f;
            MaxSpeed.fillAmount = 0.2f;

            Buy.text = "0";
        }
        if (select.text == "2")
        {
            

            Setting.fillAmount = 0.2f;
            StartSpeed.fillAmount = 0.3f;
            MaxSpeed.fillAmount = 0.6f;

            Buy.text = "3000";
        }
        if (select.text == "3")
        {
            

            Setting.fillAmount = 0.5f;
            StartSpeed.fillAmount = 0.8f;
            MaxSpeed.fillAmount = 0.4f;

            Buy.text = "6000";
        }
        if (select.text == "4")
        {
            

            Setting.fillAmount = 0.3f;
            StartSpeed.fillAmount = 0.3f;
            MaxSpeed.fillAmount = 0.7f;

            Buy.text = "10000";
        }
        if (select.text == "5")
        {
            

            Setting.fillAmount = 0.8f;
            StartSpeed.fillAmount = 0.4f;
            MaxSpeed.fillAmount = 0.5f;

            Buy.text = "10000";
        }
        if (select.text == "6")
        {
            

            Setting.fillAmount = 0.4f;
            StartSpeed.fillAmount = 0.9f;
            MaxSpeed.fillAmount = 0.2f;

            Buy.text = "10000";
        }



        
    }
}
