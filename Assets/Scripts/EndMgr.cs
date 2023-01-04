using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Fungus;

public class EndMgr : MonoBehaviour
{
    public Flowchart flowchart;

    public GameObject CG;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CGplay();
    }

    public void CGplay()
    {
        if (flowchart.GetBooleanVariable("CG") == true)
        {
            CG.SetActive(true);
        }
    }

    public  void ChangeScene()
    {
        SceneManager.LoadScene("End-2");
    }
}
