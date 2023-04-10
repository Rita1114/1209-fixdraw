using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;
using Fungus;
using UnityEngine.Assertions.Must;


public class C1lMgr : MonoBehaviour
{
    public static string DebugSceneName;
    public static int startPointNumber; //換場景的點
    public static bool 拿到糖, 拿到錢 ,拿到筆= false; //C1-L變數部分
    public static bool 豬公已對話, 糖給豬公後 = false; //C1-C變數部分
    public static bool 塗鴉手動畫出現1 = false; //C1-P變數部分
    public static bool 伯已對話, 給錢買筆後 = false; //C1-G變數部分

    public GameObject playerObject;
    public GameObject candyimage;
    public GameObject NoteC1;


    public Flowchart flowchart;

    public Item Candy;
    public Item Coin;
    public Item Drawbook;
    public Item Pen;
    public Inventory MyBook;
    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("Player");
        if (!playerObject)
        {
            SceneManager.LoadScene("");
            DebugSceneName = SceneManager.GetActiveScene().name;

        }

    
        if (startPointNumber != 0)
        {
            GameObject a = GameObject.Find(startPointNumber.ToString()) as GameObject;
            if (a != null)
            {
                playerObject.transform.position = a.transform.position;
            }

            startPointNumber = 0;
        }

     

    }

    void Update()
    {
        //bool aaa = flowchart.GetBooleanVariable("Aniplay");
        //flowchart.SetBooleanVariable("Aniplay",true);

        //Debug.Log(aaa);
        if (flowchart.GetBooleanVariable("拿到糖")==true)
        {
            GameMgr.拿到糖=true;
        }
        //移除所有道具
        if (flowchart.GetBooleanVariable("填色遊戲") == true)
        {
            MyBook.itemlist.Remove(Drawbook);
            MyBook.itemlist.Remove(Pen);
            InventoryMgr.RefreshItem();
        }
        if (flowchart.GetBooleanVariable("收集完") == true)
        {
            GameMgr.收集完 = true;

        }
        if (flowchart.GetBooleanVariable("進第二章") == true)
        {
            GameMgr.第一章BGM結束 = true;
        }
        GetCandy();
       
    }

    public  void GetCandy()
    {
        if (GameMgr.拿到糖 == true)
        {
            flowchart.SetBooleanVariable("拿到糖",true);
            if (!MyBook.itemlist.Contains(Candy) && !MyBook.itemlist.Contains(Coin))
            {
                MyBook.itemlist.Add(Candy);
                InventoryMgr.RefreshItem();
                candyimage.SetActive(true);
            }
        }
        if (GameMgr.拿到糖== true)
        {
            flowchart.SetBooleanVariable("收集完",true);
            
            
        }
    }

}
