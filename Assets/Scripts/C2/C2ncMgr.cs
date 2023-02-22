using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class C2ncMgr : MonoBehaviour
{
    public Flowchart flowchart;
    public GameObject image,player;
    public PlayableDirector animationController;

    public Inventory MyBook;
    public Item workbook;
    public Item watercolorbox;
    public Item watercolorpaper;
    public Item watercolorpen;
    public Item artroomkey;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(flowchart.GetBooleanVariable("可以走")==false)
        {
            player.GetComponent<playerCtr1>().enabled=false;
        }
        else
        {
            player.GetComponent<playerCtr1>().enabled=true;
        }
        if (flowchart.GetBooleanVariable("轉場")==true)
                {
                    image.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        animationController.Play();
                        GameMgr.中卓走美教動畫已經播過 = true;//告訴管理員走過不播動畫
                    }
                }

        if (GameMgr.中卓走美教動畫已經播過==true)
        {
            animationController.enabled = false;
            flowchart.SetBooleanVariable("可以走",true);
            flowchart.SetBooleanVariable("start",true);
        }
        if (GameMgr.拿到作業簿==true)
        {
            flowchart.SetBooleanVariable("收到作業了",true);
        }//別的場景紀錄透過管理員紀錄設定
        if (flowchart.GetBooleanVariable("拿到水彩筆")==true)
        {
            GameMgr.拿到水彩筆 = true;
            //道具添加
            if (!MyBook.itemlist.Contains(watercolorpen))
            {
                MyBook.itemlist.Add(watercolorpen);
                InventoryMgr.RefreshItem();
            }
        }//對話完畢給管理員知道
        
        
        if (GameMgr.拿到水彩筆==true)
        {
            flowchart.SetBooleanVariable("拿到水彩筆",true);
        }//透過管理員紀錄設定，避免變數消失重複事件
        
        if (flowchart.GetBooleanVariable("load")==true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
               LoadC2();
            }
        }
     
        
    }

    public static void LoadC2()
    {
        SceneManager.LoadScene("C2-C");
    }
}
