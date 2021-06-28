using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataAndRespawn : MonoBehaviour
{
    static public GameObject MyCar;//машина для статистического доступа в других скриптах
    public Vector3 settingCamera;//настройки камеры
    public GameObject cam;//камера
    public int test;// тестовый номер машины
    public List<GameObject> ArrCars = new List<GameObject>();//массив всех автомобиле   
    static public List<GameObject> ArrCarsStat = new List<GameObject>();
    static private Vector3 positionStandart;
    void Start()
    {
        
        if(test != 121)
        {
            Data.carSelect = test;
        }
        Debug.Log(Data.carSelect);

       
        positionStandart = ArrCars[0].transform.position;

        // Vector3 positionStandart = ArrCars[0].transform.position;

        if (MyCar == null)
        {
            foreach (GameObject car in ArrCars)
            {

                if (car.name != "Car" + Data.carSelect)
                {
                    Destroy(car);
                }
                else if (car.name == "Car" + Data.carSelect)
                {
                    MyCar = car;
                    //car.transform.position = positionStandart;

                }
            }
        }
       
            MyCar.transform.position = positionStandart;
        
        

    }

    
    void Update()
    {
        cam.transform.position = MyCar.transform.position + settingCamera;
    }
}
