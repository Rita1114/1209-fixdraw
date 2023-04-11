using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class C2ACMgr : MonoBehaviour
{
    public Flowchart flowchart,觸發點;

    public GameObject player,布畫板,破畫板,畫板,瑱色遊戲,櫃子,中卓;

    public Inventory MyBook;
    public Item watercolorbox;
    public Item watercolorpen;
    public Item watercolorpaper;


    public GameObject NoteC2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flowchart.GetBooleanVariable("start")==false)
        {
            player.GetComponent<playerCtr1>().enabled=false;
        }
        else
        if(flowchart.GetBooleanVariable("start")==true)
        {
            player.GetComponent<playerCtr1>().enabled=true;
        }
        
        if (flowchart.GetBooleanVariable("掀開") == true)
        {
            布畫板.SetActive(false);
            破畫板.SetActive(true);
            畫板.SetActive(false);
        }
        if (GameMgr.拿到水彩筆)
        {
           flowchart.SetBooleanVariable("有水彩筆",true);
        }

        if (GameMgr.找到水彩紙 == true)
        {
            flowchart.SetBooleanVariable("有水彩紙",true);
        }
        if (flowchart.GetBooleanVariable("開始填色遊戲") == true&& flowchart.GetBooleanVariable("有水彩筆")==true&&flowchart.GetBooleanVariable("有顏料")==true&&flowchart.GetBooleanVariable("有水彩紙")==true )
        {
          瑱色遊戲.SetActive(true);
        }

        if (GameMgr.填色遊戲完成)
        {
            flowchart.SetBooleanVariable("填色遊戲好",true);
            MyBook.itemlist.Remove(watercolorbox);
            MyBook.itemlist.Remove(watercolorpen);
            MyBook.itemlist.Remove(watercolorpaper);
            InventoryMgr.RefreshItem();
        }

        if (flowchart.GetBooleanVariable("填色遊戲好") == true)
        {
            //Destroy(破畫板);
            破畫板.SetActive(false);
            畫板.SetActive(true);
            
        }
        //BGM
        if (flowchart.GetBooleanVariable("BGM03") == true)
        {
            
            GameMgr.BGMstop = true;
            //SoundMgr2.instance2.PlayBgm03();
        }

        if (flowchart.GetBooleanVariable("鈴聲") == true)
        {
            SoundMgr.instance.PlayRingRing();
        }


        if (flowchart.GetBooleanVariable("進第三章") == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                SceneManager.LoadScene("C2AsyncLoader");
                Engine.NextLevelName = "C3-HS";
                //SceneManager.LoadScene("C3-HS");
            }
        }
        
        if (flowchart.GetBooleanVariable("找置物櫃") == true)
        {
            GameMgr.找過置物櫃 = true;
            //GameMgr.BGMstop = true;
            //SoundMgr2.instance2.PlayBgm03();

        }
        if (flowchart.GetBooleanVariable("進美術教室過") == true)
        {
            GameMgr.進過美術教室 = true;
        }

        if (GameMgr.進過美術教室 == true)
        {
            flowchart.SetBooleanVariable("進美術教室過",true);
            flowchart.SetBooleanVariable("start",true);
        }
        if (flowchart.GetBooleanVariable("掀開") == true)
        {
            GameMgr.掀開畫布 = true;
        }

        if (GameMgr.掀開畫布 == true)
        {
            flowchart.SetBooleanVariable("掀開",true);
        }
        
        if (flowchart.GetBooleanVariable("填色遊戲好") == true)
        {
            GameMgr.補完畫 = true;
        }
        if (GameMgr.補完畫 == true)
        {
            flowchart.SetBooleanVariable("掀開",true);
            flowchart.SetBooleanVariable("填色遊戲好",true);

        }

        if (GameMgr.拿到水彩顏料 == true)
        {
            flowchart.SetBooleanVariable("有顏料",true);
        } 
        if (GameMgr.找到水彩紙 == true)
        {
            flowchart.SetBooleanVariable("有水彩紙",true);
        }

        //備忘錄
        if (GameMgr.找到水彩紙 && GameMgr.拿到水彩筆 && GameMgr.拿到水彩顏料)
        {
            GameMgr.C2Note = true;
        }
        if (GameMgr.C2Note)
        {
            NoteC2.SetActive(false);
            //Destroy(NoteC2);
        }
    }
}
