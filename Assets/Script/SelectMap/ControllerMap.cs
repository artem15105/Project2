using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ControllerMap : MonoBehaviour
{
    static public int selectMap { get; private set; }

    public Text name;
    public int countMap = 3;

    private Vector3 Tpos;
    private Vector3 Fpos;

    public Texture imageMap1;
    public Texture imageMap2;
    public Texture imageMap3;

    public RawImage map;


    public Button next;
    public Button back;

    public Button play;
    public Button exit;

    public Button buy;
    public Text price;
    public Text money;



    void Start()
    {
        PlayerPrefs.SetInt("Map1", 1);

        Tpos = play.transform.position;
        Fpos = buy.transform.position;

        money.text = $"{PlayerPrefs.GetInt("Money")}";

        selectMap = 1;
        Target();
    }

    private void Target()//функция исключительно для оптимизации, вызывается когда нужно поменять кратинку(что б не вызывать каждый кадр)
    {
        if (selectMap == 1)
        {
            map.texture = imageMap1;
            name.text = "Горы";
            price.text = "3000";

            if (PlayerPrefs.GetInt("Map1") == 1)
            {
                price.text = "куплено";

                play.transform.position = Tpos;
                buy.transform.position = Fpos;
            }
            else
            {
                play.transform.position = Fpos;
                buy.transform.position = Tpos;
            }
        }
        else if (selectMap == 2)
        {
            map.texture = imageMap2;
            name.text = "Лес";
            price.text = "7000";


            if (PlayerPrefs.GetInt("Map2") == 1)
            {
                price.text = "куплено";

                play.transform.position = Tpos;
                buy.transform.position = Fpos;
            }
            else
            {
                play.transform.position = Fpos;
                buy.transform.position = Tpos;
            }
        }
        else if (selectMap == 3)
        {
            map.texture = imageMap3;
            name.text = "Дрифт";
            price.text = "9000";

            if (PlayerPrefs.GetInt("Map3") == 1)
            {
                price.text = "куплено";

                play.transform.position = Tpos;
                buy.transform.position = Fpos;
            }
            else
            {
                play.transform.position = Fpos;
                buy.transform.position = Tpos;
            }
        }
    }
 
    
    public void Next()
    {
        if (selectMap < countMap)
            selectMap++;
        Target();
    }
    public void Back()
    {
        if (selectMap > 1)
            selectMap--;
        Target();
    }

    public void Buy()
    {
        if(PlayerPrefs.GetInt("Money") - Int32.Parse(price.text) >= 0)
        {
            PlayerPrefs.SetInt("Map" + $"{selectMap}", 1);
            PlayerPrefs.SetInt("Money", PlayerPrefs.GetInt("Money") - Int32.Parse(price.text));
            Target();
        }
    }
    public void Exit()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Play()
    {
        SceneManager.LoadScene("Level" + selectMap);
    }


}
