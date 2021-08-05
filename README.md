# 89trillion-Testdocument
科目二上机项目

## **1.整体框架**
商店展示功能，主要分成两个层级：1.开始和结束时展示的面板； 2.商品展示面板
1：开始展示面板 一个按钮绑定点击时间进行图层切换
2：商品展示面板 1）一个脚本解析接收到的物品数据
             2）将数据传给商店生成展示对象
             3）实现点击购买时的金币动画


## **2.目录结构**
![image](https://github.com/89trillion-hongxiaobo/test1/blob/master/READMEIMG/test1.tree.png)

## 3.界面拆分

###### 3.1 Hierarchy分为：3.1.1 maincamera		固定视角	

###### 					          3.1.2 canvas。             界面展示

###### 							       1）开始界面，一个按钮，点击按钮弹出全屏弹窗

###### 								   2）全屏弹窗，完成卡牌展示，点击关闭返回开始界面

###### 						       3.1.3 gamemanager。  管理场景

###### 							   3.1.4 Backpack。         储存以及物品货币信息

###### 3.2 prefab：3.2.1 每日精选卡牌：商品展示界面

###### 				   3.2.2 士兵招募宝箱：宝箱

######                    3.2.3 飞出的金币：购买宝箱后的特效

###### 3.3 代码结构：

| 类名称        | 功能         | 调用关系                                           |
| ------------- | ------------ | -------------------------------------------------- |
| Gamemanager   | 主要协调脚本 | 获取json解析脚本，数据传给商城，购买数据返回给背包 |
| SimpleJSON    | 解析json     | 获取源数据                                         |
| DailyFeatured | 商品展示     | 获取商品数据，返回购买数据                         |

## 4.流程图

​       ![Untitled Diagram](https://github.com/89trillion-hongxiaobo/test1/blob/master/READMEIMG/Untitled%20Diagram.png)

## 5.第三方库

###### SimpleJson：解析json文件

https://github.com/Bunny83/SimpleJSON

