using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;
using Fungus;


public class C1GMgr : MonoBehaviour
{
    public static string DebugSceneName;
    public static int startPointNumber; //換場景的點
   
    public static bool 伯已對話, 給錢買筆後 = false; //C1-G變數部分

    public GameObject playerObject;


    public Flowchart flowchart;


    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("Player");
        if (!playerObject)
        {
            SceneManager.LoadScene("");
            DebugSceneName = SceneManager.GetActiveScene().name;

        }

        if (startPointNumber != 0)
        {
            GameObject a = GameObject.Find(startPointNumber.ToString()) as GameObject;
            if (a != null)
            {
                playerObject.transform.position = a.transform.position;
            }

            startPointNumber = 0;
        }



    }
    void Update()
    {
        if (GameMgr.拿到錢 = true)
      {
          flowchart.SetBooleanVariable("拿到錢",true);
      }
        if (GameMgr.伯已對話 = true)
        {
            flowchart.SetBooleanVariable("伯已對話",true);
        }
        
    }

    public  void GetPen()
    {
        if (flowchart.GetBooleanVariable("收集筆")==true)
        {
            GameMgr.拿到筆 = true;
            GameMgr.IsGetpan=true;

        }
    }

    public void Talked()
    {
        if (flowchart.GetBooleanVariable("對話")==true)
        {
            GameMgr.伯已對話 = true;
            GameMgr.IsGetpan=true;
            
        }
        
    }
}
