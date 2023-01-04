using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class C2ACMgr : MonoBehaviour
{
    public Flowchart flowchart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (flowchart.GetBooleanVariable("進第三章") == true)
        {
            SceneManager.LoadScene("C3-HS");
        }
    }
}
