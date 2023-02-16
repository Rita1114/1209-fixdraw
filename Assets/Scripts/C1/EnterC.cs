using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnterC : MonoBehaviour
{
    public Item Pen;//背包的圖
    public Item Book;
    public Item Coin;
    public Inventory MyBook;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void OnTriggerEnter2D(Collider2D other)
    {
     if(other.gameObject.CompareTag("Player")
     &&other.GetType().ToString()=="UnityEngine.CapsuleCollider2D")
     {
        Debug.Log("in");
        SceneManager.LoadScene("C1-C");
      
            /*if (!MyBook.itemlist.Contains(Coin))
            {
                MyBook.itemlist.Add(Coin);
                InventoryMgr.RefreshItem();
            }//檢查包包有無此物件 若無就加"";*/
        GameMgr.IsFirstTimeLinePlayed = true;
        }
    }
}
