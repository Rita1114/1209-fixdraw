using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickPaper2 : MonoBehaviour
{

    //≈‹º∆

    public bool isgreen;
    public bool RightGP;
    public bool isclick;

    public GameObject paper;
    public Sprite FillGreen;


    void Start()
    {
        isclick = false;
        RightGP = false;
        isgreen = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        isclick = Input.GetMouseButton(0);
        //
        if (isgreen && RightGP && isclick)
        {
            paper.GetComponent<SpriteRenderer>().sprite = FillGreen;
        }

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.ToLower().Contains("green"))
        {
            //Debug.Log("tt");
            isgreen = true;
        }

        if (other.name.ToLower().Contains("rightg") && isgreen)
        {
            //Debug.Log("fff");
            RightGP = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.name.ToLower().Contains("rightg") && isgreen)
        {
            //Debug.Log("fff");
            RightGP = false;
        }
    }








}
