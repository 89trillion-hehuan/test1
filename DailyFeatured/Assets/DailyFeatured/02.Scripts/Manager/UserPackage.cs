using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//用户背包（目前是存储金币和宝石数量）
public class UserPackage : MonoBehaviour
{
    //传入金币以及宝石初始值
    public int inputgem;
    public int inputgold;
    public static int Gem;
    public static int Gold;

    private void Start()
    {
        //初始化
        Gem = inputgem;
        Gold = inputgold;
    }

    public static void setGem(int gem)
    {
        Gem = gem;
    }

    public static int getGem()
    {
        return Gem;
    }

    public static void setGold(int gold)
    {
        Gold = gold;
    }

    public static int getGold()
    {
        return Gold;
    }
}