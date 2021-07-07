using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectCar : MonoBehaviour
{
    
    
    void Start()
    {
        
    }
    public void NextCar()
    {
        if (InfoCar.MainCar != InfoCar.arrCars.Count)
        {

            InfoCar.MainCar++;
            foreach (GameObject car in InfoCar.arrCars)
            {
                car.transform.position += new Vector3(0, 0, 60);
            }
            InfoCar.statusSelect = true;
        }

    }
    public void BackCar()
    {
        if (InfoCar.MainCar != 1)
        {
            InfoCar.MainCar--;
            foreach (GameObject car in InfoCar.arrCars)
            {
                Debug.Log("Test2");
                car.transform.position -= new Vector3(0, 0, 60);
            }
            InfoCar.statusSelect = true;
        }
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }

}
