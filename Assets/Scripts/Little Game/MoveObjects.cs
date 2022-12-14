using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    #region �ܼ�

    private bool isMouseDown = false;
    public bool isCliked = false;//�Q��}
    private Vector3 newposition;
    private GameObject target = null;

    #endregion

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        isMouseDown = Input.GetMouseButton(0); //���U�ƹ�����AisMouse��true
        if (!isMouseDown && isCliked)  //item�Q��ʤ���}
        {
            isCliked = false;
        }
        //item���mouse��,
        if (isCliked)
        {
            target.transform.position = transform.position; //���Ϧ�m��۷ƹ���
        }
    }

    #region MY funtion

    private void OnTriggerStay2D(Collider2D other)
    {
        if (isMouseDown && !isCliked && other.gameObject.tag == "paper") //�ƹ��S����}�B�O����
        {
            isCliked = true;
            target = GameObject.Find(other.gameObject.name); //target=���ϦW�r
            Debug.Log("AAA");
            newposition = other.transform.position; //�ª���m=������ϭ�Ӫ���m
        }
    }


    #endregion
}