using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class C1CMgr : MonoBehaviour
{
    public Flowchart flowchart;

    public GameObject hand,Coinimage,bookimage;

    public Item Drawbook;
    public Item Coin;
    public Item Candy;
    public Inventory MyBook;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flowchart.GetBooleanVariable("拿到糖")==true)
        {
            GameMgr.拿到糖 = true;
        }
        if (flowchart.GetBooleanVariable("已對話")==true)
        {
            GameMgr.豬公已對話 = true;
        }
        if (flowchart.GetBooleanVariable("吃到糖")==true)
        {
            GameMgr.糖給豬公後 = true;
            GameMgr.拿到錢買筆 = true;
            Coinimage.SetActive(true);
        }
        if (flowchart.GetBooleanVariable("拿回冊")==true)
        {
            GameMgr.拿回冊 = true;
            if (!MyBook.itemlist.Contains(Drawbook))
            {
                MyBook.itemlist.Add(Drawbook);
                InventoryMgr.RefreshItem();
                bookimage.SetActive(true);
            }
            hand.SetActive(false);
        }
        CheckCevent();


    }

    public void CheckCevent()
    {
        if (GameMgr.拿到糖 == true)
        {
            flowchart.SetBooleanVariable("拿到糖",true);
        }
        if (GameMgr.豬公已對話 == true)
        {
            flowchart.SetBooleanVariable("已對話",true);
        }
        if (GameMgr.糖給豬公後 == true)
        {
            flowchart.SetBooleanVariable("吃到糖",true);
            //Destroy(MyBook.itemlist.Contains(Candy));
            

        }
        if (GameMgr.拿回冊 == true)
        {
            flowchart.SetBooleanVariable("拿回冊",true);
        }
        if (GameMgr.拿到錢買筆 == true)
        {
            flowchart.SetBooleanVariable("拿到錢",true);
            if (!MyBook.itemlist.Contains(Coin))
            {
                MyBook.itemlist.Add(Coin);
                InventoryMgr.RefreshItem();
                GameMgr.IsFirstTimeLinePlayed = true;
            }
        }
    }
}
