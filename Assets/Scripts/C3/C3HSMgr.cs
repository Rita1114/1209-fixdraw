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
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameMgr.電話==true)
        { 
            flowchart.SetBooleanVariable("電話",true);
        }

        if (flowchart.GetBooleanVariable("電話響過")==true)
        {
            GameMgr.電話響過 = true;
        }
        
        if (GameMgr.電話響過==true)
        { 
            flowchart.SetBooleanVariable("電話響過",true);
        }
        
    }
}
