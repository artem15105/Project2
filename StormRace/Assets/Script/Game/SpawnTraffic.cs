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

        if (MainCarOb == null)//����������� ��������
        {
            MainCarOb = DataAndRespawn.MyCar;
            posCar = MainCarOb.transform.position;
        }


        if (MainCarOb.transform.position.z - posCar.z > 200 && !status)//�������� ����������� �������, ���������� ��������� ������� � ����� �������
        {
            status = true;
            posCar = MainCarOb.transform.position;
            posBigCar = MainCarOb.transform.position;
        }
        if (status)//��� ������
        {
            foreach (Rigidbody ob in realArrTraffic)//���������� �������� ���� ������� �������
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

            if (MainCarOb.transform.position.z - posBigCar.z > 500)//������ 500 ������ ������� ��������
            {
                
                Rigidbody ob = Instantiate(arrTrafficBigCars[rnd.Next(arrTrafficBigCars.Count)]);//���������� ��� �� ������� ����������
                
                ob.transform.position = new Vector3(this.gameObject.transform.position.x +  rnd.Next(-15, 15), this.gameObject.transform.position.y + 10,
                                                                                    MainCarOb.transform.position.z + 200);//� ����� ��� �������: 
                                                                                                                          //x - �����. ������(������, ������ ������)
                                                                                                                          //y ������� ����� �������
                                                                                                                          //z - ������� ���������� + ������ �� ��
                realArrTraffic.Add(ob);
                posBigCar = MainCarOb.transform.position;// ���������� �������� 500������
            }
                
            if (MainCarOb.transform.position.z - posCar.z > 150)//������ 150 ������ ��������� ������
            {                
                posCar = MainCarOb.transform.position;//���������� ��������
                List<Rigidbody> arr = new List<Rigidbody>();//������� ����� �����
                for(int i = 0; i < 5; i++)//5 �����
                {
                    arr.Add(Instantiate(arrTrafficCars[rnd.Next(arrTrafficCars.Count)]));//��������� �� ������� �����                
                }
               
                    
                
                int distanke = 200;//��������� 200 ������ �� ������ ������
          

                foreach (Rigidbody ob in arr)
                {
                    ob.mass = 500f;//����� 500 ��, (����� �� ������)
                    realArrTraffic.Add(ob);//��������� ������ � ������ �������� �����
                    ob.transform.position = new Vector3(this.gameObject.transform.position.x + rnd.Next(-16, 17), MainCarOb.transform.position.y,
                                                                                                        MainCarOb.transform.position.z + distanke);//��. ����
                    distanke += 30;//������ ������ �� 30 �. ������ ����������
                }
                //arr = new List<Rigidbody>();
              
            }
        }









    }
}
