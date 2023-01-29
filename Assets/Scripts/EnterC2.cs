using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus ;
using UnityEngine.SceneManagement;

public class EnterC2 : MonoBehaviour
{
    public Flowchart flowchart;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flowchart.GetBooleanVariable("進第二章") == true)
        {
            door.SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")
            && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            LoadC2();
            GameMgr.IsFirstTimeLinePlayed = true;
        }
      
    }
    void LoadC2()
    {
        if (flowchart.GetBooleanVariable("進第二章") == true)
        {
            SceneManager.LoadScene("AsyncLoader");
            Engine.NextLevelName = "C2-NC";
            //SceneManager.LoadScene("C2-NC");
        }
    }
}
