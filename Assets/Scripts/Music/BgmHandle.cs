using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;



public class BgmHandle : MonoBehaviour
{
    
    //public Flowchart flowchart;
    
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
        //�qDontDestroyOnLoad����
        if (GameMgr.�Ĥ@��BGM����)
        {
            Destroy(This);
        }
        if (GameMgr.�ĤG��BGM����)
        {
            Destroy(This);
            Debug.Log("�ϬM");
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
            DontDestroyOnLoad(This);//���n�R��������
            GameMgr.IsBgmReady = true;
        }
        
    }
    
}
