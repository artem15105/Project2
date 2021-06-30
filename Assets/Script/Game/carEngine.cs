using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carEngine : MonoBehaviour
{
    public Transform center;

    public int steerAngle;
    public int motorTorque;

    public List<GameObject> VisualFront;
    public List<GameObject> VisualBack;

    public List<WheelCollider> WheelFront;
    public List<WheelCollider> WheelBack;

    


    static public GameObject MainCar;
    static public Rigidbody canvasCar;
    

    void Start()
    {

        this.gameObject.GetComponent<Rigidbody>().centerOfMass = center.position;
        /*foreach (WheelCollider w in WheelFront)
        {


            WheelCollider col = w;
           
            JointSpring js = col.suspensionSpring;

           
            col.suspensionSpring = js;
          

            WheelFrictionCurve fc = col.forwardFriction;

            fc.asymptoteValue = 5000.0f;
            fc.extremumSlip = 2.0f;
            fc.asymptoteSlip = 20.0f;
           
            col.forwardFriction = fc;
            fc = col.sidewaysFriction;
            fc.asymptoteValue = 7500.0f;
            fc.asymptoteSlip = 2.0f;
           
            col.sidewaysFriction = fc;

        }
        foreach (WheelCollider w in WheelBack)
        {


            WheelCollider col = w;

            JointSpring js = col.suspensionSpring;


            col.suspensionSpring = js;


            WheelFrictionCurve fc = col.forwardFriction;

            fc.asymptoteValue = 5000.0f;
            fc.extremumSlip = 2.0f;
            fc.asymptoteSlip = 20.0f;

            col.forwardFriction = fc;
            fc = col.sidewaysFriction;
            fc.asymptoteValue = 7500.0f;
            fc.asymptoteSlip = 2.0f;

            col.sidewaysFriction = fc;

        }*/
    }

    
    void Update()
    {

        if (Input.GetKey("w"))
        {
            //this.gameObject.GetComponent<Rigidbody>().AddForce(Mathf.Atan2(this.gameObject.transform.rotation.x, this.gameObject.transform.rotation.y));
            WheelBack[0].motorTorque = motorTorque;
            WheelBack[1].motorTorque = motorTorque;
        }
        else if (Input.GetKey("s"))
        {
            WheelBack[0].motorTorque = -motorTorque;
            WheelBack[1].motorTorque = -motorTorque;
        }
        else
        {
            WheelBack[0].motorTorque = 0;
            WheelBack[1].motorTorque = 0;
        }

        if (Input.GetKey("a"))
        {
            WheelFront[0].steerAngle = -steerAngle;
            WheelFront[1].steerAngle = -steerAngle; 
        }
        else if(Input.GetKey("d"))
        {
            WheelFront[0].steerAngle = steerAngle;
            WheelFront[1].steerAngle = steerAngle; 
        }
        else
        {
            WheelFront[0].steerAngle = 0;
            WheelFront[1].steerAngle = 0;
        }
        /*
        VisualFront[0].transform.rotation = WheelFront[0].transform.rotation;
        VisualFront[1].transform.rotation = WheelFront[1].transform.rotation;

        VisualBack[0].transform.rotation = WheelBack[0].transform.rotation;
        VisualBack[1].transform.rotation = WheelBack[1].transform.rotation;
        */

    }
}
