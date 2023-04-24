using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickPaper2 : MonoBehaviour
{
    //�ܼ�
    public static MouseClickPaper2 instanceMCP2 ;
    public bool isclick=false;
    //�����C��
    public bool bluecolor=false;
    public bool redcolor = false;
    public bool yellowcolor = false;
    public bool greencolor = false;
    public bool purplecolor = false;

    //�C�ƸI��
    private bool isblue=false;
    private bool isred=false;
    private bool isyellow=false;
    private bool isgreen=false;
    private bool ispurple=false;
    //��m
    public bool isb = false;
    public bool isr = false;
    public bool isy = false;
    public bool isg = false;
    public bool isp = false;
    //�C���
    public GameObject bluecolorblack;
    public GameObject redcolorblack;
    public GameObject yellowcolorblack;
    public GameObject greencolorblack;
    public GameObject purplecolorblack;

    public GameObject WordpaperGame;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        isclick = Input.GetMouseButton(0);
        //
        /*if (isgreen && RightGP && isclick)
        {
            paper.GetComponent<SpriteRenderer>().sprite = FillGreen;
        }
        */
        //�{�b�����C��
        #region
        if (isclick && isblue)
        {
            bluecolor = true;
            redcolor = false;
            yellowcolor = false;
            greencolor = false;
            ispurple = false;
        }
        if (isclick && isred)
        {
            redcolor = true;
            bluecolor = false;
            yellowcolor = false;
            greencolor = false;
            ispurple = false;
        }
        if (isclick && isgreen)
        {
            greencolor = true;
            bluecolor = false;
            redcolor = false;
            yellowcolor = false;
            ispurple = false;
        }
        if (isclick && isyellow)
        {
            yellowcolor = true;
            bluecolor = false;
            redcolor = false;
            greencolor = false;
            ispurple = false;

        }
        if (isclick && ispurple)
        {
            purplecolor = true;
            bluecolor = false;
            redcolor = false;
            yellowcolor = false;
            greencolor = false;
        }
        #endregion

        //�W��
        if (bluecolor && isclick && isb)
        {
            Debug.Log("reaction");
            bluecolorblack.SetActive(true);
        }
        if (redcolor && isclick && isr)
        {
            redcolorblack.SetActive(true);
        }
        if (yellowcolor && isclick && isy)
        {
            yellowcolorblack.SetActive(true);
        }
        if (greencolor && isclick && isg)
        {
            greencolorblack.SetActive(true);
        }
        if (purplecolor && isclick && isp)
        {
            purplecolorblack.SetActive(true);
            GameMgr.填色遊戲完成 = true;
        }



    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //���}�@����C��
        if (other.name.ToLower().Contains("wordpaper") && isclick)
        {
            //WordpaperGame.SetActive(true);
        }
        //�C���C�⥬�L�u��
        #region
        if (other.name.ToLower().Contains("blue"))
        {
            //Debug.Log("tt");
            isblue = true;
        }
        if (other.name.ToLower().Contains("red"))
        {
            isred = true;
        }
        if (other.name.ToLower().Contains("green"))
        {
            isgreen = true;
        }
        if (other.name.ToLower().Contains("yellow"))
        {
            isyellow = true;
        }
        if (other.name.ToLower().Contains("purple"))
        {
            ispurple = true;
        }
        #endregion

        //�O�_��m���T
        
        if (other.name.ToLower().Contains("fillb"))
        {
            //Debug.Log("tt");
            isb = true;
        }
        if (other.name.ToLower().Contains("fillr"))
        {
            isr = true;
        }
        if (other.name.ToLower().Contains("fillg"))
        {
            isg = true;
        }
        if (other.name.ToLower().Contains("filly"))
        {
            isy = true;
        }
        if (other.name.ToLower().Contains("fillp"))
        {
            isp = true;
        }
        
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        
        #region
        if (other.name.ToLower().Contains("blue"))
        {
            //Debug.Log("tt");
            isblue = false;
        }
        if (other.name.ToLower().Contains("red"))
        {
            isred = false;
        }
        if (other.name.ToLower().Contains("green"))
        {
            isgreen = false;
        }
        if (other.name.ToLower().Contains("yellow"))
        {
            isyellow = false;
        }
        if (other.name.ToLower().Contains("purple"))
        {
            ispurple = false;
        }

        //��m
        
        if (other.name.ToLower().Contains("fillb"))
        {
            //Debug.Log("tt");
            isb = false;
        }
        if (other.name.ToLower().Contains("fillr"))
        {
            isr = false;
        }
        if (other.name.ToLower().Contains("fillg"))
        {
            isg = false;
        }
        if (other.name.ToLower().Contains("filly"))
        {
            isy = false;
        }
        if (other.name.ToLower().Contains("fillp"))
        {
            isp = false;
        }
        #endregion
    }








}
