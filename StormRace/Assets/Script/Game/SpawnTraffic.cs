using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class SpawnTraffic : MonoBehaviour
{
    private System.Random rnd = new System.Random();
    private Vector3 posCar;
    private Vector3 posBigCar;

    public GameObject MainCarOb = null;
    private bool status = false;

    public List<Rigidbody> realArrTraffic = new List<Rigidbody>();

    public List<Rigidbody> arrTrafficCars = new List<Rigidbody>();
    public List<Rigidbody> arrTrafficBigCars = new List<Rigidbody>();

    void Start()
    {
        
       
    }

    void Update()
    {

        if (MainCarOb == null)//определение обьектов
        {
            MainCarOb = DataAndRespawn.MyCar;
            posCar = MainCarOb.transform.position;
        }


        if (MainCarOb.transform.position.z - posCar.z > 200 && !status)//проверка определения обьекта, назначение начальной позиции и старт скрипта
        {
            status = true;
            posCar = MainCarOb.transform.position;
            posBigCar = MainCarOb.transform.position;
        }
        if (status)//сам скрипт
        {
            foreach (Rigidbody ob in realArrTraffic)//постоянная прибавка силы машинам трафика
            {
                if(ob != null)
                {
                    ob.AddForce(0, 0, 3500);
                    if (MainCarOb.transform.position.z - ob.transform.position.z > 500 || ob.transform.position.z - MainCarOb.transform.position.z > 500)
                    {
                        Destroy(ob.gameObject);
                    }
                }           
            }

            if (MainCarOb.transform.position.z - posBigCar.z > 500)//каждые 500 метров создает грузовик
            {
                
                Rigidbody ob = Instantiate(arrTrafficBigCars[rnd.Next(arrTrafficBigCars.Count)]);//скопировав его из массива грузовиков
                
                ob.transform.position = new Vector3(this.gameObject.transform.position.x +  rnd.Next(-15, 15), this.gameObject.transform.position.y + 10,
                                                                                    MainCarOb.transform.position.z + 200);//и задав ему позицию: 
                                                                                                                          //x - текущ. обьект(пустой, центре дороги)
                                                                                                                          //y позиция текущ обьекта
                                                                                                                          //z - позиция автомобиля + метров от неё
                realArrTraffic.Add(ob);
                posBigCar = MainCarOb.transform.position;// обновления счетчика 500метров
            }
                
            if (MainCarOb.transform.position.z - posCar.z > 150)//каждые 150 метров респавнит машины
            {                
                posCar = MainCarOb.transform.position;//орновление счетчика
                List<Rigidbody> arr = new List<Rigidbody>();//обььект копий машин
                for(int i = 0; i < 5; i++)//5 машин
                {
                    arr.Add(Instantiate(arrTrafficCars[rnd.Next(arrTrafficCars.Count)]));//рандомных из массива машин                
                }
               
                    
                
                int distanke = 200;//дистанция 200 метров от машины игрока
          

                foreach (Rigidbody ob in arr)
                {
                    ob.mass = 500f;//масса 500 кг, (лучше не менять)
                    realArrTraffic.Add(ob);//добавляет машину в массив реальных машин
                    ob.transform.position = new Vector3(this.gameObject.transform.position.x + rnd.Next(-16, 17), MainCarOb.transform.position.y,
                                                                                                        MainCarOb.transform.position.z + distanke);//см. выше
                    distanke += 30;//каждая машина на 30 м. дальше предыдущей
                }
                //arr = new List<Rigidbody>();
              
            }
        }









    }
}
