using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class Characteristics : MonoBehaviour
{
    public Image Constrol;
    public Image Acceleration;
    public Image MaxSpeed;

    public Text Money;
    public Text Price;
    static public int PriceInt;

    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        Money.text = $"{PlayerPrefs.GetInt("Money")}";
        if(Price.text != "Куплена")
        {
            PriceInt = Int32.Parse(Price.text);
        }
       
        if ("Car" + InfoCar.MainCar == "Car1")
        {

            Constrol.gameObject.transform.localScale = new Vector3(0.7f, 0.4f, 1);//x - длина, y = ширина, z - хз,
                                                                                  //вроде никак не влияет но лучше оставить 1
            Acceleration.gameObject.transform.localScale = new Vector3(0.5f, 0.4f, 1);
            MaxSpeed.gameObject.transform.localScale = new Vector3(0.3f, 0.4f, 1);

            Price.text = "5000";

            if (PlayerPrefs.GetInt("Car1") == 1)
            {
                Price.text = "Куплена";
            }
        }
        else if("Car" + InfoCar.MainCar == "Car2")
        {

            Constrol.gameObject.transform.localScale = new Vector3(0.3f, 0.4f, 1);                       
            Acceleration.gameObject.transform.localScale = new Vector3(0.3f, 0.4f, 1);
            MaxSpeed.gameObject.transform.localScale = new Vector3(0.8f, 0.4f, 1);

            Price.text = "5000";

            if (PlayerPrefs.GetInt("Car2") == 1)
            {
                Price.text = "Куплена";
            }
        }
        else if ("Car" + InfoCar.MainCar == "Car3")
        {

            Constrol.gameObject.transform.localScale = new Vector3(0.4f, 0.4f, 1);
            Acceleration.gameObject.transform.localScale = new Vector3(0.9f, 0.4f, 1);
            MaxSpeed.gameObject.transform.localScale = new Vector3(0.6f, 0.4f, 1);

            Price.text = "5000";

            if (PlayerPrefs.GetInt("Car3") == 1)
            {
                Price.text = "Куплена";
            }
        }
    }
}
