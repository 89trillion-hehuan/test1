using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VO;

public class InitProduct : MonoBehaviour
{
    //商品展示预制件
    public GameObject ProductShow;

    //生成预制件的父亲
    public GameObject ShopContent;

    //锁定状态预制件
    public GameObject Unlock;

    //宝箱预制件
    public GameObject TreasureShow;

    //士兵招募横幅
    public GameObject SoldierRecruitmentBlueBannerImage;

    //json数据源
    public string data;

    //方便调整商品展示预制件的间隔以及y轴位置
    public int XOffset;
    public int YOffset;

    void Start()
    {
        //读取json（商品信息）
        List<ProductVO> json = Jsonread.JsovF(data);

        //商品名称
        string productname = "null";

        //商品路径以及名称，通过 imagepath+imagename生成显示图片路径
        string imagepath = null;
        string imagename = "null";

        //商品花费
        string cost = null;

        //根据json数据条数生成商品展示框
        for (int i = 0; i < json.Count; i++)
        {
            //根据商品类型调整商品名称；图片显示路径；消耗货币数量
            switch (json[i].type)
            {
                case 1:
                    productname = "金币";
                    imagepath = "coin_1";
                    cost = json[i].costGold.ToString();
                    break;
                case 2:
                    productname = "宝石";
                    imagepath = "diamond_2";
                    cost = json[i].costGem.ToString();
                    break;
                case 3:
                    productname = "卡片";
                    imagepath = "cards/" + json[i].subType;
                    cost = json[i].costGold.ToString();
                    break;
            }


            string text = cost.ToString();

            //创建商品栏
            GameObject newobj = Instantiate(ProductShow);

            //根据读取顺序调整商品栏位置
            Vector3 position = new Vector3(133 + ((i % 3) * XOffset), (i / 3 + 1) * (-437) + YOffset, 0);
            newobj.GetComponent<Transform>().SetParent(ShopContent.transform);
            newobj.GetComponent<Transform>().localPosition = position;
            newobj.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);

            //设置商品名称
            newobj.transform.Find("ProductName").GetComponent<Text>().text = productname;

            //根据商品类型生成图片
            newobj.transform.Find("ProductImage").GetComponent<Image>().sprite =
                Resources.Load(imagepath, typeof(Sprite)) as Sprite;

            //如果以及购买则直接显示以及购买，否则显示商品购买按钮
            if (json[i].isPurchased == 1)
            {
                newobj.transform.Find("hasBought").gameObject.SetActive(true);
                newobj.transform.Find("ShowPanel").gameObject.SetActive(false);
            }
            else
            {
                newobj.transform.Find("hasBought").gameObject.SetActive(false);
                newobj.transform.Find("ShowPanel").gameObject.SetActive(true);
            }

            //设置商品金额
            newobj.transform.Find("ShowPanel/Price").GetComponent<Text>().text = cost;

            //激活展示栏
            newobj.SetActive(true);
        }

        for (int i = 0; i < 3 - json.Count % 3; i++)
        {
            GameObject newobj = Instantiate(Unlock);

            int offset = i + json.Count;

            //根据读取顺序调整商品栏位置
            Vector3 position = new Vector3(133 + ((offset % 3) * XOffset), (offset / 3 + 1) * (-437) + YOffset, 0);
            newobj.GetComponent<Transform>().SetParent(ShopContent.transform);
            newobj.GetComponent<Transform>().localPosition = position;
            newobj.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        }

        //生成并调整横幅位置
        GameObject soliderbanner = Instantiate(SoldierRecruitmentBlueBannerImage);
        Vector3 banner_position = new Vector3(370, (json.Count / 3 + 1) * (-437) - 280, 0);
        soliderbanner.GetComponent<Transform>().SetParent(ShopContent.transform);
        soliderbanner.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        soliderbanner.GetComponent<Transform>().localPosition = banner_position;
        soliderbanner.SetActive(true);

        //生成并调整宝箱位置
        GameObject treasure = Instantiate(TreasureShow);
        Vector3 trea_position = new Vector3(133, (json.Count / 3 + 1) * (-437) + YOffset - 550, 0);
        treasure.GetComponent<Transform>().SetParent(ShopContent.transform);
        treasure.GetComponent<Transform>().localScale = new Vector3(1, 1, 1);
        treasure.GetComponent<Transform>().localPosition = trea_position;
        treasure.SetActive(true);
    }
}