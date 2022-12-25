using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Playables;
using Fungus;


public class C1lMgr : MonoBehaviour
{
    public static string DebugSceneName;
    public static int startPointNumber;//換場景的點
    public static bool 拿到糖,拿到錢=false; //C1-L變數部分
    public static bool 豬公已對話,糖給豬公後=false; //C1-C變數部分
    public static bool 塗鴉手動畫出現1=false;//C1-P變數部分
    public static bool 伯已對話, 給錢買筆後=false;//C1-G變數部分
    
    public GameObject playerObject;

    
    public Flowchart flowchart;

   
    // Start is called before the first frame update
    void Start()
    {
        playerObject =GameObject.Find("Player");
        if(!playerObject)
        {
            SceneManager.LoadScene("");
            DebugSceneName=SceneManager.GetActiveScene().name;
            
        }
        if(startPointNumber !=0)
        {
           GameObject a=GameObject.Find(startPointNumber.ToString()) as GameObject;
           if(a !=null)
           {
            playerObject.transform.position= a.transform.position;
           }
           startPointNumber=0;
        }
       

        
    }
     void Update()
    {
        
    }
}