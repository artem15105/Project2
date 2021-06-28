using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class SpawnAsphalt : MonoBehaviour
{
    public GameObject car;
    private float posCar;
    public GameObject Asphalt;
    private int count = 0;//������� ��� ����������� ���������� ��������� ������
    private int ArrCount = 0;//������� ��� ��������
    private List<GameObject> arrClone = new List<GameObject>();// ������ ��� ������ ��������

    
    void Start()
    {
        car = this.gameObject;//�������� �� ������
        posCar = car.transform.position.z;//��������� �������
        
    }

    
    void Update()
    {
        
                                  
        if (car.transform.position.z - posCar > 100)//������ 100 ������ �������
        {
            posCar = car.transform.position.z;
            
            count += 200;//������ ��� �� 200 � ������ ���������� ����������
            
            {
                GameObject clonAsphalt = Instantiate(Asphalt);//������� ��������� � ������� �����
                arrClone.Add(clonAsphalt);//���������� � �������� ������ ������ ��� ������������ ��������(�����������)
                clonAsphalt.transform.position += new Vector3(0, 0, count);//����������� ���������
            }
             
        }
        if(arrClone.Count > ArrCount)//�����������, ���� ���-�� ��������� ������ ��� � ��������
        {
            
            if( car.transform.position.z - arrClone[ArrCount].transform.position.z > 100)//���� ������ ������� �� 100 ������ �� ������, ������ ���������
            {
               
                Destroy(arrClone[ArrCount]);
                ArrCount++;// � ������������ �������
            }
        }
    }
}
