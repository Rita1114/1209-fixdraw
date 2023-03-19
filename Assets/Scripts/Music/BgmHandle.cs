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
        //�qDontDestroyOnLoad����
        if (flowchart.GetBooleanVariable("�i�ĤG��") == true)
        {
            Destroy(This);
        }
        if (flowchart.GetBooleanVariable("�q��") == true)
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
            DontDestroyOnLoad(This);//���n�R��������
            GameMgr.IsBgmReady = true;
        }
        
    }
    
}
