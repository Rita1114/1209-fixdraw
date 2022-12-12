using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class ChangeImage : MonoBehaviour
{
    public Texture2D images;
    public GameObject none;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Onclick()
    {
        none.GetComponent<RawImage>().texture = images;
        Debug.Log("1");

    }
}
