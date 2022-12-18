using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    #region 變數

    private bool isMouseDown = false;
    public bool isCliked = false;//被放開
    private Vector3 newposition;
    private GameObject target = null;

    public GameObject GetTool;
    #endregion

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        isMouseDown = Input.GetMouseButton(0); //按下滑鼠左鍵，isMouse為true
        if (!isMouseDown && isCliked)  //item被拖動中放開
        {
            isCliked = false;
        }
        //item跟著mouse走,
        if (isCliked)
        {
            target.transform.position = transform.position; //拼圖位置跟著滑鼠走
        }
    }

    #region MY funtion
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.ToLower().Contains("watercolor paper")&& isMouseDown)
        {
            GetTool.SetActive(true);
        }
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (isMouseDown && !isCliked && other.gameObject.tag == "paper") //滑鼠沒有放開且是拼圖
        {
            isCliked = true;
            target = GameObject.Find(other.gameObject.name); //target=拼圖名字
            Debug.Log("AAA");
            newposition = other.transform.position; //舊的位置=抓取拼圖原來的位置
        }
    }


    #endregion
}
