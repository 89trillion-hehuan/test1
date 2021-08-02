using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//显示金币
public class ShowGold : MonoBehaviour
{
    void Update()
    {
        //刷新显示金币数量
        gameObject.GetComponent<Text>().text = UserPackage.getGold().ToString();
    }
}