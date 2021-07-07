using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;



public class InfoCar : MonoBehaviour
{
    private Vector3 osnova;
    static public  bool statusSelect = true;//статусная переменная, нужна в коде ниже



    public GameObject Buy;
    public GameObject Play;

    static public int Money;

    static public int MainCar = 1;//текущая машина

    public List<GameObject> arrCars2 = new List<GameObject>();

    static public List<GameObject> arrCars = new List<GameObject>();
    static public Dictionary<string, bool> ShopCar = new Dictionary<string, bool>();


    void Start()
    {
        PlayerPrefs.SetInt("Car1", 1);
        osnova = Play.transform.position;

       
        arrCars = arrCars2;

<<<<<<< HEAD
        for(int i2 = 1; i2 <= arrCars.Count; i2++)
        {
            ShopCar.Add("Car" + i2, false);
        }
=======
        if(ShopCar.Count <= 2)
        {
            for (int i2 = 1; i2 <= arrCars.Count; i2++)
            {
                ShopCar.Add("Car" + i2, false);
            }
        }
        
>>>>>>> 8343c9f9847b84566029a52759ef51e61b44f8ac


               
    }

    
    void Update()
    {
        PlayerPrefs.SetInt("CurrentVehicle", MainCar - 1);


        if (Input.GetKey("y"))
        {
            
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") + 1000);
        }
        if (Input.GetKey("u"))
        {
            
            PlayerPrefs.DeleteAll();
        }
        

        Money = PlayerPrefs.GetInt("Money");
        if (PlayerPrefs.GetInt("Car" + MainCar) == 1)
        {
           
            Play.transform.position = osnova;
            Buy.transform.position  = new Vector3(2000, 0, 0);

            
        }
        else if(PlayerPrefs.GetInt("Car" + MainCar) != 1)
        {
            
            Play.transform.position = new Vector3(2000, 0, 0);
            Buy.transform.position  = osnova;

            
        }
    }
}
