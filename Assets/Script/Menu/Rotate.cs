using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
   
    void Start()
    {
           
    }

    
    void FixedUpdate()
    {
        transform.Rotate(0, 0.7f, 0);
    }
}
