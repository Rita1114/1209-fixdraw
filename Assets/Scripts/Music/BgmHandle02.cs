using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmHandle02 : MonoBehaviour
{
    
    public GameObject This;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameMgr.�ĤG��BGM����)
        {
            Destroy(This);
        }
    }
    private void Awake()
    {
        if (GameMgr.IsBgmReady02)
        {
            Destroy(This);
        }
        else
        {
            DontDestroyOnLoad(This);//���n�R��������
            GameMgr.IsBgmReady02 = true;
        }

    }
}
