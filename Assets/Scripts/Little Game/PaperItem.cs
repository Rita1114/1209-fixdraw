using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperItem : MonoBehaviour
{
    #region ≈‹º∆

    public bool isChongHe = false;
    private GameObject mouseObject;


    #endregion
    void Start()
    {
        mouseObject = GameObject.Find("mouse");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "position")
        {
            if (!mouseObject.GetComponent<MoveObjects>().isCliked)
            {
                Debug.Log("BBB");
                this.transform.position = other.transform.position;
                
            }
        }
    }

}
