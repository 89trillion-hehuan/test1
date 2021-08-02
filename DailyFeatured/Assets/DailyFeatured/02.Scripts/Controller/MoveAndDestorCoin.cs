using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//金币的位移以及销毁
public class MoveAndDestorCoin : MonoBehaviour
{
    //金币初始位置
    public Vector3 resposition = new Vector3(0, 0, 0);

    //金币目标位置
    public Vector3 desposition = new Vector3(1, 4.8f, 0);

    private void Start()
    {
        //定时销毁
        Invoke("onTimeDestory", 3);
    }

    void Update()
    {
        //移动金币将起始位置和目标位置做差*deltatime 形成缓慢移动的效果
        gameObject.GetComponent<Transform>().localPosition = gameObject.GetComponent<Transform>().position
                                                             + (desposition - gameObject.GetComponent<Transform>()
                                                                 .position) * Time.deltaTime;
    }

    void onTimeDestory()
    {
        //销毁
        Destroy(gameObject);
    }
}