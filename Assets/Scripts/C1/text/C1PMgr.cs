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
            冊被搶 = true; 
            book.SetActive(false);
        }
    }
}