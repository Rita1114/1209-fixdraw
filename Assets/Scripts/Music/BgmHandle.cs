using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;


public class BgmHandle : MonoBehaviour
{
    public Flowchart flowchart;
    //public BgmHandle bgmHandle;
    public static BgmHandle BGMHinstance;
    public GameObject BGM;
    public GameObject This;

    
    void Start()
    {
        
    }

    void Update()
    {
        if (GameMgr.BGMstop)
        {
            BGM.SetActive(false);
        }
        else
        {
            //Debug.Log("TTTT");
            BGM.SetActive(true);
        }
        //從DontDestroyOnLoad移除
        if (flowchart.GetBooleanVariable("進第二章") == true)
        {
            Destroy(This);
        }
        if (flowchart.GetBooleanVariable("電話") == true)
        {
            Destroy(This);
        }

    }
    private void Awake()
    {
        if (GameMgr.IsBgmReady)
        {
            Destroy(This);
        }
        else
        {
            DontDestroyOnLoad(This);//不要刪除此物件
            GameMgr.IsBgmReady = true;
        }
        
    }
    
}
