using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class SpawnAsphalt : MonoBehaviour
{
    public GameObject car;
    private float posCar;
    public GameObject Asphalt;
    private int count = 0;//счетчек дл€ посто€нного увеличени€ дистанции спавна
    private int ArrCount = 0;//счетчик дл€ удалени€
    private List<GameObject> arrClone = new List<GameObject>();// массив дл€ клонов асфальта

    
    void Start()
    {
        car = this.gameObject;//вешаетс€ на машину
        posCar = car.transform.position.z;//начальна€ позици€
        
    }

    
    void Update()
    {
        
                                  
        if (car.transform.position.z - posCar > 100)//каждые 100 метров респавн
        {
            posCar = car.transform.position.z;
            
            count += 200;//каждый раз на 200 м больше начального полождени€
            
            {
                GameObject clonAsphalt = Instantiate(Asphalt);//респавн определен с помощью копий
                arrClone.Add(clonAsphalt);//добавление в основной массив клонов дл€ последующего удалени€(оптимизаци€)
                clonAsphalt.transform.position += new Vector3(0, 0, count);//определение дистанции
            }
             
        }
        if(arrClone.Count > ArrCount)//оптимизаци€, если кол-во элементов больше чем в счетчике
        {
            
            if( car.transform.position.z - arrClone[ArrCount].transform.position.z > 100)//если машина отехала на 100 метров от дороги, дорога удал€етс€
            {
               
                Destroy(arrClone[ArrCount]);
                ArrCount++;// и прибавл€етс€ счетчик
            }
        }
    }
}
