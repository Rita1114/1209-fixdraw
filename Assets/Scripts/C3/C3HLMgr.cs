using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class C3HLMgr : MonoBehaviour
{
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flowchart.GetBooleanVariable("填色遊戲完成")==true)
        {
            GameMgr.事件完成 = true;
        }

        if (GameMgr.事件完成 == true)
        {
            flowchart.SetBooleanVariable("事件完成",true);
            GameMgr.電話 = true;
        }
    }
}
