using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmHandle04 : MonoBehaviour
{
    public GameObject This;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void Awake()
    {
        if (GameMgr.IsBgmReady04)
        {
            Destroy(This);
        }
        else
        {
            DontDestroyOnLoad(This);//���n�R��������
            GameMgr.IsBgmReady04 = true;
        }

    }
}
