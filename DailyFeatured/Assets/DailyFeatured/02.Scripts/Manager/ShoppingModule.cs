using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//商品购买模块提供购买以及获得金币功能
public class ShoppingModule : MonoBehaviour
{
    //使用金币购买
    public bool PurchaseInGold(GameObject Item)
    {
        //获得商品价格
        int price = int.Parse(Item.GetComponent<Text>().text);
        
        //判断金币数量是否足够，足够则扣费，否则无效果
        if (UserPackage.getGold() >= price)
        {
            UserPackage.setGold(UserPackage.getGold() - price);
            return true;
        }
        else
        {
            Debug.Log("Not enough money");
            return false;
        }
    }

    
    //获得金币
    public void ObtainGold(GameObject Item)
    {
        //获得金币获取数量，金币增加
        int price = int.Parse(Item.GetComponent<Text>().text);
        UserPackage.setGold(UserPackage.getGold() + price);
    }

    //获得金币重载（传入金币价格方式不同）
    public void ObtainGold(int price)
    {
        UserPackage.setGold(UserPackage.getGold() + price);
    }
}