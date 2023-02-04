using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PaperChangeImage : MonoBehaviour
{
    public Button paper;
    public GameObject PP;
    public Sprite newpaper;
    public Sprite sprite0;
    public bool isChange = false;
    
    void Start()
    {
        paper.onClick.AddListener(Changepaper);
    }

    
    void Update()
    {
        if (isChange)
        {
           
            PP.GetComponent<Image>().sprite = newpaper;
            
        }
        else
        {
            PP.GetComponent<Image>().sprite = sprite0;
        }

    }
    private void Changepaper()
    {
        isChange = !isChange;
        SoundMgr.instance.PlayTurnPages();
    }
}
