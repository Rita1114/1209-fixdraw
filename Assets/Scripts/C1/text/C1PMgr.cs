using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class C1PMgr : MonoBehaviour
{
    public Flowchart flowchart;
    public PlayableDirector playableDirector;
    public static bool 冊被搶=false;
    public GameObject book;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flowchart.GetBooleanVariable("冊被搶")==true)
        {
            playableDirector.Play();
            GameMgr.冊被搶 = true; 
            book.SetActive(false);
            GameMgr.塗鴉手動畫出現1 = true;
        }

        if (GameMgr.冊被搶==true)
        {
            flowchart.SetBooleanVariable("冊被搶",true);
        }
        
    }
}
