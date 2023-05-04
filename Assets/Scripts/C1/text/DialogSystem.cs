using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogSystem : MonoBehaviour
{
    [Header("UI")] 
    public Text textlabel;
    public Image faceImage;
    
    [Header("文本文件")] 
    public TextAsset textFile ;
    public int index;
    private List<string> textList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        GetTextFormFile(textFile);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetTextFormFile(TextAsset file)
    {
        textList.Clear();
        index = 0;

        var linDate = file.text.Split('\n');

        foreach (var line in linDate)
        {
            textList.Add(line);
        }
    }
}
