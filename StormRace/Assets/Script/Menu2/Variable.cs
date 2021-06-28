using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Variable : MonoBehaviour
//select.text - ЭТО ЧИСЛО (но в типе string), которое хранит в себе номер выбранной машины !!!
{
    public int CountCars;    //сколько машин всего

    public Text select;      //Текст с выбранной машиной,(int)
    public Text Buy;         //текст с ценой(int)
    public Text ButtonCenter;//кнопка по центру, это или играть, или купить в0зависимости от того куплена ли машина  

    public Dictionary<string, bool> ArrBuyCars = new Dictionary<string, bool>();// массив в который будут помещены все имеющиеся машины, <Название, Куплена ли?>
    public Image Setting;    //Принимает шкалу управления
    public Image StartSpeed; //Принимает шкалу Ускорения
    public Image MaxSpeed;   //Принимает шкалу максимальной 

    public void Center()
    {
        
        if (PlayerPrefs.GetInt("car" + select.text) == 1)
        {
            ButtonCenter.text = "Играть";
        }
        else
        {
            ButtonCenter.text = "Купить";
        }
    }

    public void Click()
    {
        if (PlayerPrefs.GetInt("car" + select.text) == 1)//если машина куплена то при нажатии на кнопку переходит на другую сцену
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else   //если машина не куплена то при нажатии на кнопку првоеряет достаточно ли денег для её покупки,
               // если достаточно то покупает её, и сохраняет покупку
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

        //Создание массива, по типу: "Car1" => true
        for(int i = 1; i <= CountCars; i++)
        {
            ArrBuyCars.Add($"car{i}", false);
        }
        PlayerPrefs.SetInt("car1", 1);//первая машина у всех куплена

        /*for(int i = 1; i < ArrBuyCars.Count; i++)
        {
          
            if (PlayerPrefs.GetInt("car" + i) == 1) { ArrBuyCars["car" + 1] = true; };
        }
        foreach (KeyValuePair<string, bool> car in ArrBuyCars)
        {
            if (PlayerPrefs.GetInt(car.Key) == 1) { ArrBuyCars[car.Key] = true; };
        }
        if (PlayerPrefs.GetInt("car2") == 1) { ArrBuyCars["car2"] = true; }; - тестовый метод
        */

        
    }


    void Update()
    {
        //Debug.Log(PlayerPrefs.GetInt("car" + select.text)); - тестовый метод
        Center();//все время проверяет состояние кнопки по центру, и если это требуется то меняет её текст
        
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
        //тестовые методы, для добавления и обнуления бюджета
       
        //взависимости от выбранной машины выставляет соответствующие характеристики для шкал и текст кнопки по центру
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
