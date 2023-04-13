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
        if (GameMgr.電話響過==true)
        {
            Load();
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
