using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public int pointNumber;
    public string nextSceneName;
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
        SceneManager.LoadScene("C3AsyncLoader");
        Engine.NextLevelName = "End-1";
        //SceneManager.LoadScene(nextSceneName);
        Point.startPointNumber = pointNumber;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")
        && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            Load();
            GameMgr.IsFirstTimeLinePlayed = true;
        }

    }
}
