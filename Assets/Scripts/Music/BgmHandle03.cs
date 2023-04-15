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
        if (GameMgr.第三章BGM結束)
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
            DontDestroyOnLoad(This);//不要刪除此物件
            GameMgr.IsBgmReady03 = true;
        }

    }
}
