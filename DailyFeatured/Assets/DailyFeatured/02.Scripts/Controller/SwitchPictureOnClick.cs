using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPictureOnClick : MonoBehaviour
{
    //切换之前的图层以及切换之后的图层
    public GameObject beforeimage;
    public GameObject afterimage;

    //统计点击次数
    private int count = 0;

    //是否可重复使用 true只可以切换一次 false可往复切换
    public bool isSingle = true;

    public void OnClick()
    {
        //点击后切换点击前图册以及之后图层的显示
        if (count == 0 || isSingle == false)
        {
            beforeimage.SetActive(!beforeimage.activeSelf);
            afterimage.SetActive(!afterimage.activeSelf);
        }

        //点击次数+1
        count++;
    }
}