using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickPaper2 : MonoBehaviour
{
    //�ܼ�
    public static MouseClickPaper2 instanceMCP2 ;
    public bool isclick=false;

    public bool bluecolor=false;
    public bool redcolor = false;
    public bool yellowcolor = false;
    public bool greencolor = false;
    public bool purplecolor = false;

    //�C��
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





    void Start()
    {
        isclick = false;
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
        if (isclick && isblue)
        {
            bluecolor = true;
        }
        if (isclick && isred)
        {
            redcolor = true;
        }
        if (isclick && isgreen)
        {
            greencolor = true;
        }
        if (isclick && isyellow)
        {
            yellowcolor = true;
        }
        if (isclick && ispurple)
        {
            purplecolor = true;
        }
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        //�C���C�⥬�L�u��
        if (other.name.ToLower().Contains("blue"))
        {
            //Debug.Log("tt");
            isblue = true;
        }
        if (other.name.ToLower().Contains("red"))
        {
            //Debug.Log("tt");
            isred = true;
        }
        if (other.name.ToLower().Contains("green"))
        {
            //Debug.Log("tt");
            isgreen = true;
        }
        if (other.name.ToLower().Contains("yellow"))
        {
            //Debug.Log("tt");
            isyellow = true;
        }
        if (other.name.ToLower().Contains("purple"))
        {
            //Debug.Log("tt");
            ispurple = true;
        }
        //�O�_��m���T
        /*
        if (other.name.ToLower().Contains("b"))
        {
            //Debug.Log("tt");
            isb = true;
        }
        if (other.name.ToLower().Contains("r"))
        {
            //Debug.Log("tt");
            isr = true;
        }
        if (other.name.ToLower().Contains("g"))
        {
            //Debug.Log("tt");
            isg = true;
        }
        if (other.name.ToLower().Contains("y"))
        {
            //Debug.Log("tt");
            isy = true;
        }
        if (other.name.ToLower().Contains("p"))
        {
            //Debug.Log("tt");
            isp = true;
        }
        */
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.name.ToLower().Contains("blue"))
        {
            //Debug.Log("tt");
            isblue = false;
        }
        if (other.name.ToLower().Contains("red"))
        {
            //Debug.Log("tt");
            isred = false;
        }
        if (other.name.ToLower().Contains("green"))
        {
            //Debug.Log("tt");
            isgreen = false;
        }
        if (other.name.ToLower().Contains("yellow"))
        {
            //Debug.Log("tt");
            isyellow = false;
        }
        if (other.name.ToLower().Contains("purple"))
        {
            //Debug.Log("tt");
            ispurple = false;
        }

        //��m
        /*
        if (other.name.ToLower().Contains("b"))
        {
            //Debug.Log("tt");
            isb = false;
        }
        if (other.name.ToLower().Contains("r"))
        {
            //Debug.Log("tt");
            isr = false;
        }
        if (other.name.ToLower().Contains("g"))
        {
            //Debug.Log("tt");
            isg = false;
        }
        if (other.name.ToLower().Contains("y"))
        {
            //Debug.Log("tt");
            isy = false;
        }
        if (other.name.ToLower().Contains("p"))
        {
            //Debug.Log("tt");
            isp = false;
        }
        */
    }








}
