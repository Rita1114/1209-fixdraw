using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;


public class C2toMgr : MonoBehaviour
{
    public Flowchart flowchart;

    public GameObject GetTool;
    public Button CloseGet;

    public Inventory MyBook;
    public Item workbook;
    public Item watercolorpen;

    void Start()
    {
        CloseGet.onClick.AddListener(CloseG);
    }

    // Update is called once per frame
    void Update()
    {
        if (flowchart.GetBooleanVariable("第一次說")==true)
        {
            GameMgr.第一次對話完 = true;
        }//對話完畢給管理員知道
        if (GameMgr.第一次對話完==true)
        {
            flowchart.SetBooleanVariable("第一次說完",true);
        }//透過管理員紀錄設定，避免變數消失
        
        if (flowchart.GetBooleanVariable("第二次說")==true)
        {
            GameMgr.第二次對話完 = true;
        }//對話完畢給管理員知道
        if (GameMgr.第二次對話完==true)
        {
            flowchart.SetBooleanVariable("第二次說完",true);
        }//透過管理員紀錄設定，避免變數消失
        
        
        if (flowchart.GetBooleanVariable("第二次說完")==true)
        {
            GameMgr.第三次對話 = true;
        }//對話完畢給管理員知道
        
        if (flowchart.GetBooleanVariable("第三次說完")==true)
        {
            GameMgr.第三次說完 = true;
            
            if (GameMgr.第三次說完)
            {
                if (!MyBook.itemlist.Contains(workbook) && !MyBook.itemlist.Contains(watercolorpen))
                {
                    MyBook.itemlist.Add(workbook);
                    InventoryMgr.RefreshItem();
                    GetTool.SetActive(true);
                }
                //道具添加
            }
            
           
        }
                

        if (GameMgr.第三次對話==true)
        {
            flowchart.SetBooleanVariable("拿到作業",true);
            
          
        }//透過管理員紀錄設定，避免變數消失
        
        
        if (flowchart.GetBooleanVariable("拿到作業")==true)
        {
            GameMgr.拿到作業簿 = true;
        }//對話完畢給管理員知道
        if (GameMgr.拿到作業簿==true)
        {
            flowchart.SetBooleanVariable("拿到作業",true);
            
          
        }
        else
        {
            flowchart.SetBooleanVariable("拿到作業", false);
        }
        //透過管理員紀錄設定，避免變數消失


    }
    public void CloseG()
    {
        GetTool.SetActive(false);
    }
    

}
   

