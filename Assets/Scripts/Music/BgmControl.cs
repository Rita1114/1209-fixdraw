using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmControl : MonoBehaviour
{
    bool isbgmStop=false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("STOP");
            GameMgr.BGMstop = !GameMgr.BGMstop;
            
        }
    }
}
