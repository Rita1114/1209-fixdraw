using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class C2ACMgr : MonoBehaviour
{
    public Flowchart flowchart,觸發點;

    public GameObject player,布畫板,破畫板,畫板,瑱色遊戲,櫃子;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(flowchart.GetBooleanVariable("start")==false)
        {
            player.GetComponent<playerCtr1>().enabled=false;
        }
        else
        if(flowchart.GetBooleanVariable("start")==true)
        {
            player.GetComponent<playerCtr1>().enabled=true;
        }
        
        if (flowchart.GetBooleanVariable("掀開") == true)
        {
            布畫板.SetActive(false);
            破畫板.SetActive(true);
            畫板.SetActive(false);
        }
        if (GameMgr.拿到水彩筆)
        {
           flowchart.SetBooleanVariable("有水彩筆",true);
        }
        if (flowchart.GetBooleanVariable("開始填色遊戲") == true&& flowchart.GetBooleanVariable("有水彩筆")==true )
        {
          瑱色遊戲.SetActive(true);
        }

        if (GameMgr.填色遊戲完成)
        {
            flowchart.SetBooleanVariable("填色遊戲好",true);
        }

        if (flowchart.GetBooleanVariable("填色遊戲好") == true)
        {
            Destroy(破畫板);
            //破畫板.SetActive(false);
            畫板.SetActive(true);
        }

        if (flowchart.GetBooleanVariable("進第三章") == true)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                SceneManager.LoadScene("C2AsyncLoader");
                Engine.NextLevelName = "C3-HS";
                //SceneManager.LoadScene("C3-HS");
            }
        }
        if (flowchart.GetBooleanVariable("找置物櫃") == true)
        {
            GameMgr.找過置物櫃 = true;
        }
        if (flowchart.GetBooleanVariable("進美術教室過") == true)
        {
            GameMgr.進過美術教室 = true;
        }

        if (GameMgr.進過美術教室 == true)
        {
            flowchart.SetBooleanVariable("進美術教室過",true);
        }
    }
}
