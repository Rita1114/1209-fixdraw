using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class ChangeImage : MonoBehaviour
{
    public Texture2D images;
    public GameObject none;
    public Sprite[] sparray = new Sprite[5];
    public int change;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
     
    }

    public void Onclickadd()
    {
        //none.GetComponent<SpriteRenderer>().sprite = ;
            Debug.Log("1");
            none.GetComponent<SpriteRenderer>().sprite = sparray[change++];
    }
    public void Onclick()
    {
        //none.GetComponent<SpriteRenderer>().sprite = ;
        Debug.Log("2");
        none.GetComponent<SpriteRenderer>().sprite = sparray[change--];
    }
}
