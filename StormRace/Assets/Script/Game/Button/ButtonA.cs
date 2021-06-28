using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonA : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    static public bool KeyA = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        KeyA = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        KeyA = false;
    }




    void Start()
    {

    }


    void Update()
    {

    }
}
