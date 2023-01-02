using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Point : MonoBehaviour
{
    public static string DebugSceneName;
    public static int startPointNumber; //���������I

    public GameObject playerObject;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
