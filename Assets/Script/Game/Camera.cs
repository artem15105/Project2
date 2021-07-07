using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Ocamera;
    public GameObject car = null; 
    void Start()
    {
        Ocamera = this.gameObject;
        
    }

    
    void Update()
    {
       
        if(car == null)
        {
            Debug.Log("1");
            car = carEngine.MainCar;
        }
        else if (car != null)
        {
            Debug.Log("2");
            Ocamera.transform.position = car.transform.position + new Vector3(0, 5, -10);
        }
        
    }
}
