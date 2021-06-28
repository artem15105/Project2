using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;


public class Drive : MonoBehaviour
{


    public bool status;//жива ли машинап

    public Transform COM;
    public Rigidbody car;

    public WheelCollider[] forward = new WheelCollider[2];
    public WheelCollider[] back = new WheelCollider[2];

    public Transform[] dataFront = new Transform[2];
    public Transform[] dataBack  = new Transform[2];

    public float maxSpeed = 100f;
    public float breakSpeed = 30f;
    public float sideSpeed = 30f;

    static public float realSpeed = 0;
    void Start()
    {
        
        car.centerOfMass = COM.localPosition;
    }
    void FixedUpdate()
    {
        if (Restart.statusCar)
        {
            float vAxis = Input.GetAxis("Vertical");
            float hAxis = Input.GetAxis("Horizontal");
            bool brake = Input.GetKey("v");



            if (Input.GetKey("w") || ButtonW.KeyW)
            {
                if (car.gameObject.name == "Car3")
                {
                    car.AddForce(0, 0, 50000);
                }
                foreach (WheelCollider col in forward)
                {
                    col.motorTorque = maxSpeed;
                }
                foreach (WheelCollider col in back)
                {
                    col.motorTorque = maxSpeed;
                }
                car.AddForce(0, 0, 3500);
            }
            else if (Input.GetKey("s") || ButtonS.KeyS)
            {
                foreach (WheelCollider col in forward)
                {
                    col.motorTorque = -maxSpeed;
                }
                foreach (WheelCollider col in back)
                {
                    col.motorTorque = -maxSpeed;
                }
            }
            else
            {
                foreach (WheelCollider col in forward)
                {
                    col.motorTorque = 0;
                }
                foreach (WheelCollider col in back)
                {
                    col.motorTorque = 0;
                }
            }
            if (Input.GetKey("d") || ButtonD.KeyD)
            {

                forward[0].steerAngle = sideSpeed;
                forward[1].steerAngle = sideSpeed;


            }
            else if (Input.GetKey("a") || ButtonA.KeyA)
            {
                forward[0].steerAngle = -sideSpeed;
                forward[1].steerAngle = -sideSpeed;


            }
            else
            {

                if (forward[0].steerAngle < 0)
                {
                    forward[0].steerAngle += 10f;
                    forward[1].steerAngle += 10f;
                }
                if (forward[0].steerAngle > 0)
                {
                    forward[0].steerAngle -= 10f;
                    forward[1].steerAngle -= 10f;
                }

            }




            if (brake)
            {
                foreach (WheelCollider col in forward)
                {
                    col.brakeTorque = Mathf.Abs(col.motorTorque) * breakSpeed;
                }
                foreach (WheelCollider col in back)
                {
                    col.brakeTorque = Mathf.Abs(col.motorTorque) * breakSpeed;
                }
            }
            else
            {
                foreach (WheelCollider col in forward)
                {
                    col.brakeTorque = 0;
                }
                foreach (WheelCollider col in back)
                {
                    col.brakeTorque = 0;
                }
            }

            realSpeed = car.velocity.magnitude * 3.6f;



            dataFront[0].Rotate(forward[0].rpm * Time.deltaTime, 0, 0);
            dataFront[1].Rotate(forward[1].rpm * Time.deltaTime, 0, 0);



            dataBack[0].Rotate(back[0].rpm * Time.deltaTime, 0, 0);
            dataBack[1].Rotate(back[1].rpm * Time.deltaTime, 0, 0);


            /*if (car.velocity.magnitude * 3.6f > 1000)// || Input.GetKey("g"))
           {

               smoke1.Play();
               smoke2.Play();
               smoke3.Play();
               smoke4.Play();
           }

           smoke1.transform.position = forward[0].transform.position;
           smoke2.transform.position = forward[1].transform.position;
           smoke3.transform.position = back[0].transform.position;
           smoke4.transform.position = back[1].transform.position;

           forward[0].motorTorque = vAxis * maxSpeed;
           forward[1].motorTorque = vAxis * maxSpeed*/
        }
        else
        {
            Destroy(car);
        }
    }      
       
}
