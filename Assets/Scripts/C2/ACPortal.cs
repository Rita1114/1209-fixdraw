using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class ACPortal : MonoBehaviour
{
    public int pointNumber;
    public string nextSceneName;
    public Flowchart flowchart;
    void Start()
    {
        this.transform.tag = "Portal";
    }

    // Update is called once per frame
    void Update()
    {
        if (GameMgr.找過置物櫃 == true)
        {
            flowchart.SetBooleanVariable("找置物櫃",true);
        }
    }
    public void Load()
    {
        SceneManager.LoadScene(nextSceneName);
        Point.startPointNumber = pointNumber;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")
        && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {Debug.Log("123");
        
            if (flowchart.GetBooleanVariable("找置物櫃")==true)
            {
                Load();
            }
            
            GameMgr.IsFirstTimeLinePlayed = true;
        }

    }

    public void LoadEnd()
    {
        SceneManager.LoadScene("C3AsyncLoader");
        Engine.NextLevelName = "End-1";
    }
}
