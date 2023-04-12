using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class C3HSMgr : MonoBehaviour
{
    
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        SoundMgr2.instance2.PlayBgm03();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameMgr.電話 == true)
        {
            flowchart.SetBooleanVariable("電話", true);
        }

        if (flowchart.GetBooleanVariable("電話響過") == true)
        {
            GameMgr.電話響過 = true;
        }

        if (GameMgr.電話響過 == true)
        {
            flowchart.SetBooleanVariable("電話響過", true);
        }

        if (flowchart.GetBooleanVariable("start") == true)
        {
            GameMgr.BGMstop = false;

        }

        if (flowchart.GetBooleanVariable("鈴聲") == true)
        {
            SoundMgr.instance.PlayRingRing();
        }
        if (flowchart.GetBooleanVariable("掛斷") == true)
        {
            SoundMgr.instance.PlayRingEnd();
        }
    }
}
