using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperChangeImage : MonoBehaviour
{
    public Button paper;
    public GameObject PP;
    public Sprite newpaper;
    void Start()
    {
        paper.onClick.AddListener(Changepaper);
    }

    
    void Update()
    {
        
    }
    private void Changepaper()
    {
        Debug.Log("AAA");
        PP.GetComponent<Image>().sprite = newpaper;
    }
}
