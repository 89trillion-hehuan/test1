using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitCoin : MonoBehaviour
{
    //统计购买次数
    public static int count = 1;
    
    //生成的金币
    public GameObject Coin;
    
    //引入商店模块实现获得金币
    private ShoppingModule Shop = new ShoppingModule();

    public void OnClick()
    {
        //如果购买次数小于3获得购买次数*5的金币
        if (count < 3)
        {
            Shop.ObtainGold(count * 5);
        }
        //否则最多获得15个金币
        else
        {
            Shop.ObtainGold(15);
        }

        //对生成的金币设置延迟，产生层次感
        for (int i = 0; i < count * 5 && i < 16; i++)
        {
            Invoke("DelayedExecution", 0.1f * i);
        }
        
        //购买次数+1
        count++;
    }

    public void DelayedExecution()
    {
        //生成金币位置生成位移偏差防止堆叠
        GameObject newobj = Instantiate(Coin);
        float x = Random.Range(0f, 0.2f);
        float y = Random.Range(0f, 0.2f);
        newobj.GetComponent<Transform>().localPosition = new Vector3(x, y, 0);
    }
}