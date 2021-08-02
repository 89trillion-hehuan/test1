using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGameObject : MonoBehaviour
{
    //生成的对象
    public GameObject resObject;

    //生成对象的父类
    public string ParentObjectname;

    //xyz轴的偏差以及缩放设置
    public int xOffset;
    public int yOffset;
    public int zOffset;
    public int scale;

    public void OnClick()
    {
        //获得父对象以及创建生成对象
        GameObject ParentObject = GameObject.Find(ParentObjectname);
        GameObject newobj = Instantiate(resObject);

        //给生成对象设置坐标以及大小
        newobj.GetComponent<Transform>().SetParent(ParentObject.transform);
        newobj.GetComponent<Transform>().localPosition = new Vector3(xOffset, yOffset, zOffset);
        newobj.GetComponent<Transform>().localScale = new Vector3(scale, scale, scale);
        newobj.SetActive(true);
    }
}