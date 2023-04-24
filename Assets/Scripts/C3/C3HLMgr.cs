using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class C3HLMgr : MonoBehaviour
{
    public Flowchart flowchart;

    public  GameObject 婆婆,辭職信;
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
            Destroy(婆婆);
        }

        play();



    }
    public void play()
    {
        if(flowchart.GetBooleanVariable("辭職信") == true)
        {
            辭職信.SetActive(true);
        }
    }

   
}
