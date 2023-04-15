using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMbox : MonoBehaviour
{
   
    void Start()
    {
        
    }

   
    void Update()
    {
       
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameMgr.²Ä¤T³¹BGMµ²§ô = true;
        }
    }

    

}
