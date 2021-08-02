using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using SimpleJSON;
using VO;

//读取json
public class Jsonread
{
    public static List<ProductVO> JsovF(string data)
    {
        //定义写入商品实体类的列表
        List<ProductVO> jsonVo = new List<ProductVO>();

        //读取文件名称
        TextAsset txtobj = Resources.Load<TextAsset>(data);

        //simplejson提供的json反序列化
        JSONNode json = JSONNode.Parse(txtobj.text);

        //将读取的数据写入列表
        JSONNode T = json[0];
        for (int i = 0; i < T.Count; i++)
        {
            ProductVO Vo = new ProductVO();
            Vo.productId = T[i]["productId"];
            Vo.type = T[i]["type"];
            Vo.subType = T[i]["subType"];
            Vo.num = T[i]["num"];
            Vo.costGem = T[i]["costGem"];
            Vo.isPurchased = T[i]["isPurchased"];
            Vo.costGold = T[i]["costGold"];
            jsonVo.Add(Vo);
        }

        return jsonVo;
    }
}