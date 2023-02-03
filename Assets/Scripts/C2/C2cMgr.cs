using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class C2cMgr : MonoBehaviour
{
    public Flowchart flowchart;
    public PlayableDirector animationController;
    public GameObject player;
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        if(flowchart.GetBooleanVariable("可以走")==false)
        {
            player.GetComponent<playerCtr1>().enabled=false;
        }
        if (flowchart.GetBooleanVariable("進畫室")==true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                SceneManager.LoadScene("C2-AC");
            }

            GameMgr.走過走廊 = true;
        }
    }
}
