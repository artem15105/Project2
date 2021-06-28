using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class NextCar : MonoBehaviour
{
    public Text select;//текст, который создан только для содержания 1 числа, выбранной на данный момент машины
    

    public List<GameObject> ArrayCars = new List<GameObject>();//array cars 
   



    public void NextVariable()//метод перебирающий все элементы ArrayCars, и смещающий их по оси X на -53,
                              //а так же определяющий select.text
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
    public void BackVariable()//метод перебирающий все элементы ArrayCars, и смещающий их по оси X на +53
                              //а так же определяющий select.text
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
