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
        /*if (GameMgr.第一章==false)
        {
            SoundMgr2.instance2.PlayBgm01();
        }*/
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
        /*
        if (GameMgr.第一章BGM結束)
        {
            BGM.SetActive(false);
            //Destroy(This);
        }

        if (GameMgr.第二章BGM結束)
        {
            Destroy(This);
            Debug.Log("反映");
        }*/
        



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
