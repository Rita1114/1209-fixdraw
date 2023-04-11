using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using Fungus;
using UnityEngine.SceneManagement;

public class TimelineMgr : MonoBehaviour
{

    public PlayableDirector AnimationController;
    public TimelineAsset[] timelines;
    public string[] timelinename;
    public Flowchart flowchart;
    private float duration=5;
    public GameObject player;
    public GameObject Bubble;
    public GameObject C3填色遊戲;
    
    public bool gamestart;
    
    public enum Status{AnimOn,AnimOff};
    public Status status;

    // Start is called before the first frame update
      public void Awake()
    {
        
        // load savefile
        if (GameMgr.IsFirstTimeLinePlayed)
        {
           flowchart.SetBooleanVariable("Aniplay",true);
           flowchart.SetBooleanVariable("canwalk",true);
        }
    }


    public void Start()
    {
        


       for (int i=0; i<timelines.Length; i++)
      {
            if (flowchart.GetBooleanVariable(timelinename[i]))
        {  
            AnimationController.Play(timelines[i]);
            flowchart.SetBooleanVariable(timelinename[i],false);
            gamestart=true;
                
            }
      }
    } 
    // Update is called once per frame

    
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
      {
          Invoke(nameof(look),duration);
      }
      switch(status)
        {
          case Status AnimOn:
          if(flowchart.GetBooleanVariable("start")==false)
          {
           player.GetComponent<playerCtr1>().enabled=false;
          }
          else
          if(flowchart.GetBooleanVariable("start")==true)
          {
           player.GetComponent<playerCtr1>().enabled=true;
                    
          }
          break;
        }
       
      
      if(flowchart.GetBooleanVariable("卓盈走路")==true)
          {
           if(Input.GetKeyDown(KeyCode.Mouse0))
           {
            AnimationController.Play(timelines[2]);

           }
          }
           
          if(flowchart.GetBooleanVariable("跟小女孩說話")==true)
          {
           player.GetComponent<playerCtr1>().enabled=false;
           Bubble.SetActive(false);
          }
          else
          {
            player.GetComponent<playerCtr1>().enabled=true;
          }
          if(flowchart.GetBooleanVariable("被推")==true)
          {
           if(Input.GetKeyDown(KeyCode.Mouse0))
           {
            AnimationController.Play(timelines[3]);
           }
          }
        if (flowchart.GetBooleanVariable("進第一章") == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
               
                SceneManager.LoadScene("C1-L");
            }
        }

        if (flowchart.GetBooleanVariable("BGM") == true)
        {
            Debug.Log("BGM撥放");
            SoundMgr.instance.Bgm01();
        }
        //C2變數
        if (flowchart.GetBooleanVariable("美術老師進") == true)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                AnimationController.Play(timelines[0]);
            }
        }
        if (flowchart.GetBooleanVariable("美術老師出去") == true)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                AnimationController.Play(timelines[1]);
            }
        }
        if (flowchart.GetBooleanVariable("我沒關係出") == true)
                {
                    if(Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        AnimationController.Play(timelines[2]);
                    }
                }
        //C3變數
        if (flowchart.GetBooleanVariable("婆婆出去") == true)
        {
            if(Input.GetKeyDown(KeyCode.Mouse0))
            {
                AnimationController.Play(timelines[0]);
            }
        }
        if (flowchart.GetBooleanVariable("填色遊戲開始") == true)
        {
            C3填色遊戲.SetActive(true);
            player.GetComponent<playerCtr1>().enabled=false;
        }
        if (GameMgr.C3填色遊戲中==true)
        { 
           flowchart.SetBooleanVariable("填色遊戲中",true);
        } 
        if (flowchart.GetBooleanVariable("填色遊戲完成") == true)
        {
            player.GetComponent<playerCtr1>().enabled=true;
            GameMgr.電話 = true;
        }
        

    }
    private void FixedUpdate()
    {
       
    }
    private void look()
    {
      if(flowchart.GetBooleanVariable("四處環視")==true)
      {
        AnimationController.Play(timelines[1]);
      }
        
        
    }

    

}
