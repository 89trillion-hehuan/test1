using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//场景切换
public class SceneSwitch : MonoBehaviour
{
    //切换之前的状态
    public GameObject initpanel;

    //切换之后的状态
    public GameObject startpanel;


    public void ActiveStartPanel()
    {
        //场景状态切换形成场景切换
        initpanel.SetActive(!initpanel.activeSelf);
        startpanel.SetActive(!initpanel.activeSelf);
    }
}