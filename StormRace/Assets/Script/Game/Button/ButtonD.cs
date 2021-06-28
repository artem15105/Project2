using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonD : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    static public bool KeyD = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        KeyD = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        KeyD = false;
    }




    void Start()
    {

    }


    void Update()
    {

    }
}
