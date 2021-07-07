using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseButton : MonoBehaviour
{
    
   public void Purchase()
    {
        if(PlayerPrefs.GetInt("Money") >= Characteristics.PriceInt)
        {
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - Characteristics.PriceInt);
            PlayerPrefs.SetInt("Car" + InfoCar.MainCar, 1);
        }
    }
}
