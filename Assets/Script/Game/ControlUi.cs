using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControlUi :  MonoBehaviour//, IDragHandler, IPointerDownHandler,IPointerUpHandler,IPointerClickHandler
{
    

    static public bool top;
    static public bool back;
    static public bool left;
    static public bool right;

    public void DownTop()
    {
        Debug.Log("Hello");
        top = true;
    }
    public void UpTop()
    {
        top = false;
    }

    public void DownBack()
    {
        back = true;
    }
    public void UpBack()
    {
        back = false;
    }

    public void DownLeft()
    {
        left = true;
    }
    public void UpLeft()
    {
        left = false;
    }

    public void DownRight()
    {
        right = true;
    }
    public void UpRight()
    {
        right = false;
    }
}
