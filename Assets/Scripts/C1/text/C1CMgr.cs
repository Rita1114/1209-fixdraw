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
        EatCandy();
        Talked();

    }

    public void EatCandy()
    {
        if (flowchart.GetBooleanVariable("吃到糖")==true)
        {
            C1lMgr.糖給豬公後 = true;

        }
        DontDestroyOnLoad(this);
    }
    public void Talked()
    {
        if (flowchart.GetBooleanVariable("已對話")==true)
        {
            C1lMgr.豬公已對話 = true;
        }
        DontDestroyOnLoad(this);
    }
}
