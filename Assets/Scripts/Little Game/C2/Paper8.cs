using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Paper8 : MonoBehaviour
{
    public Button paper;
    public GameObject PP;
    public Sprite newpaper;
    public Sprite sprite0;
    bool isChange = false;
    public GameObject Watercolor;
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
            Watercolor.SetActive(false);
            PP.GetComponent<Image>().sprite = sprite0;
            
        }

    }
    private void Changepaper()
    {
        isChange = !isChange;
        SoundMgr.instance.PlayTurnPages();
    }
}
