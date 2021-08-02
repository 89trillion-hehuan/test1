using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buy : MonoBehaviour
{
    //购买之前显示的对象
    public GameObject BeforeBuy;

    //购买之后显示的对象
    public GameObject AfterBuy;

    //提供购买价格的组件
    public GameObject price;
    public GameObject button;

    //new商店模块提供购买功能
    private ShoppingModule Shop = new ShoppingModule();


    void Start()
    {
        //初始化
        BeforeBuy.SetActive(true);
        AfterBuy.SetActive(false);
    }

    public void onclick()
    {
        if (Shop.PurchaseInGold(price))
        {
            //点击按钮后切换开关
            BeforeBuy.SetActive(false);
            AfterBuy.SetActive(true);
            Destroy(button);
        }
    }
}