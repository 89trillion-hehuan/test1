using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//定时销毁对象
public class DestoryOnTime : MonoBehaviour
{
    //关闭时间
    public float timeoff;

    //销毁对象
    public GameObject GameObjectwilldestory;

    public void setDestoryOnTime()
    {
        Invoke("destory", timeoff);
    }

    private void destory()
    {
        Destroy(GameObjectwilldestory);
    }
}