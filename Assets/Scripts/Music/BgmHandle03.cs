using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmHandle03 : MonoBehaviour
{

    public GameObject This;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameMgr.�ĤT��BGM����)
        {
            Destroy(This);
        }
    }
    private void Awake()
    {
        if (GameMgr.IsBgmReady03)
        {
            Destroy(This);
        }
        else
        {
            DontDestroyOnLoad(This);//���n�R��������
            GameMgr.IsBgmReady03 = true;
        }

    }
}
