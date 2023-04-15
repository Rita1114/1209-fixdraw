using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;



public class BgmHandle : MonoBehaviour
{
    
    //public Flowchart flowchart;
    
    public GameObject BGM;
    public GameObject This;

    public AudioSource BGMSoure;
    
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

        if (GameMgr.第一章BGM結束)
        {
            Destroy(This);
        }
        
        //從DontDestroyOnLoad移除




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
