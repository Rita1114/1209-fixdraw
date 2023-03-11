using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseForChange : MonoBehaviour
{
    public GameObject A;
    public GameObject B;
    void Start()
    {
        
    }

    void Update()
    {
      //transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));  
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (A)
        {
            B.SetActive(true);
        }
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (A)
        {
            B.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (A)
        {
            B.SetActive(false);
        }
    }


}
