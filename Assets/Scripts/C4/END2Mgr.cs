using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;
using UnityEngine.UI;

public class END2Mgr : MonoBehaviour
{
    public Flowchart flowchart;

    public GameObject 卓image;
    public GameObject 筆記本image;
    public GameObject 致謝image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Loadbook();
        LoadThank();


    }

    public void Loadbook()
    {
        if (flowchart.GetBooleanVariable("筆記本") == true)
        {
            卓image.SetActive(false);
            筆記本image.SetActive(true);
        }
    }
    public void LoadThank()
    {
        if (flowchart.GetBooleanVariable("致謝") == true)
        {
            筆記本image.SetActive(false);
            致謝image.SetActive(true);
        }
    }
}
