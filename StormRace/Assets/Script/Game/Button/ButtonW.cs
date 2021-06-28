using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class ButtonW : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    static public bool KeyW = false;
        public void OnPointerDown(PointerEventData eventData)
        {
            KeyW = true;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            KeyW = false;
        }
    private void Update()
    {
       
    }
}
