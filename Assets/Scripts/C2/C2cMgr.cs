using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class C2cMgr : MonoBehaviour
{
    public Flowchart flowchart;
    public PlayableDirector animationController;
    public  GameObject player,Bulletinboard;
    public C2cMgr c2CMgr;

    
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
        if (flowchart.GetBooleanVariable("進畫室")==true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                SceneManager.LoadScene("C2-AC");
            }
            GameMgr.走過走廊 = true;//告訴管理員走過不播動畫
        }

        if (GameMgr.走過走廊)
        {
            flowchart.SetBooleanVariable("播過了",true);
            flowchart.SetBooleanVariable("可以走",true);
            
        }//透過管理員紀錄設定，避免變數消失重複事件

        if (flowchart.GetBooleanVariable("播過了")==true)
        {
            animationController.enabled = false;
        }
        if (flowchart.GetBooleanVariable("布告欄") == true&&flowchart.GetBooleanVariable("找布告欄過")==false)
        {
            Bulletinboard.SetActive(true);
        }

        if (GameMgr.找到水彩紙==true)
        {
            flowchart.SetBooleanVariable("找布告欄過",true);
        }
    }
    public  void bulletinboard()
    {
       
    }
}
