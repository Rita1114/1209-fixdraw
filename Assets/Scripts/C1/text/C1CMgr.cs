using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class C1CMgr : MonoBehaviour
{
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (GameMgr.拿到糖=true)
        {
            flowchart.SetBooleanVariable("拿到糖",true);
        }
        if (GameMgr.豬公已對話 = true)
        {
            flowchart.SetBooleanVariable("已對話",true);
        }
        if (GameMgr.糖給豬公後 = true)
        {
            flowchart.SetBooleanVariable("吃到糖",true);
            GameMgr.拿到錢 = true;
        }

    }
}
