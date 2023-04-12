using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMbox : MonoBehaviour
{
    public bool IsTouch = false;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (IsTouch)
        {
            SoundMgr2.instance2.PlayBgmend();
            GameMgr.BGMstop = true;
            
        }
        else
        {
            //GameMgr.�ĤG��BGM���� = false;
            Debug.Log("�^�_");
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IsTouch = true;
            
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            IsTouch = false;
        }
    }

}
