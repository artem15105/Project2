using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonS : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    static public bool KeyS = false;
    public void OnPointerDown(PointerEventData eventData)
    {
        KeyS = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        KeyS = false;
    }
        
        
    

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
