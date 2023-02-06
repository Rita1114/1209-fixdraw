using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class PortalC2AC : MonoBehaviour
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
        
    }
    public void Load()
    {
        SceneManager.LoadScene(nextSceneName);
        Point.startPointNumber = pointNumber;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")
        && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D"
        &&(flowchart.GetBooleanVariable("找置物櫃")==true))
        {
            Load();
            GameMgr.IsFirstTimeLinePlayed = true;
        }

    }

    public void LoadEnd()
    {
        SceneManager.LoadScene("C3AsyncLoader");
        Engine.NextLevelName = "End-1";
    }
}
