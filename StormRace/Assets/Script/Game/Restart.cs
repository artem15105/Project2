using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Restart : MonoBehaviour
{
    public GameObject OsnovaPanel;
    public GameObject Target;
    static public Vector3 PosTarget;

   
    static public  bool statusCar = true;//сттатус машины
    private bool Panel = true;//статус панели

    private GameObject car = null;//машина

    static private Vector3 MainPosCar; //= DataAndRespawn.MyCar.transform.position;

    public Text score;//очки 
    public Text money;//монеты

    void Start()
    {
        if(PosTarget == null)
        {
            PosTarget = Target.transform.position;
           
        }
    }

    
    void Update()
    {
        if(car == null)
        {
            car = DataAndRespawn.MyCar;
            MainPosCar = car.transform.position;
        }
        
        

        //if( car.transform.position.y - MainPosCar.y > 20 && statusCar)
        if (Math.Abs(MainPosCar.y - car.transform.position.y  ) > 40 && statusCar)
        {
            Debug.Log("Test");
            statusCar = false;
        }

        if (!statusCar && Panel)
        {
            Debug.Log("Test2");
            Panel = false;

            score.text = Score.DopScore;
            int mon1 = Int32.Parse(score.text) / 10;
            int mon2 = mon1 + PlayerPrefs.GetInt("Count");

            PlayerPrefs.SetInt("Count", mon2);

            money.text = $"{ PlayerPrefs.GetInt("Count")}";
           

            OsnovaPanel.transform.transform.position += new Vector3(-550, 0, 0);
        }
    }
    public void relog()
    {
        
        statusCar = true;
        Panel = true;
        
        Score.DopScore = "0";
        RealSpeed.GlobalSpeed = 0;
       
        Drive.realSpeed = 0;
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
        //OsnovaPanel.transform.transform.position += new Vector3(550, 0, 0);

    }
    public void exit()
    {
        Data.statusDelete = true;
        SceneManager.LoadScene("Menu2");
    }
}
