using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class C2ncMgr : MonoBehaviour
{
    public Flowchart flowchart;
    public GameObject image;
    public PlayableDirector animationController;
    
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (flowchart.GetBooleanVariable("轉場")==true)
                {
                    image.SetActive(true);
                    if (Input.GetKeyDown(KeyCode.Mouse0))
                    {
                        animationController.Play();
                        GameMgr.中卓走美教動畫已經播過 = true;
                    }
                }

        if (GameMgr.中卓走美教動畫已經播過=true)
        {
            animationController.enabled = false;
        }
    }

    public static void LoadC2()
    {
        SceneManager.LoadScene("C2-C");
    }
}
