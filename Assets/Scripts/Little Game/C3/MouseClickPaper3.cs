using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickPaper3 : MonoBehaviour
{
    public bool isclick = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
        isclick = Input.GetMouseButton(0);
    }
}
