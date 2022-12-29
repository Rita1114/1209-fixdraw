using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class Date : MonoBehaviour
{
    public Flowchart flowchart;
    public  bool 拿到糖, 拿到錢 ,拿到筆= false; //C1-L變數部分
    public  bool 豬公已對話, 糖給豬公後 = false; //C1-C變數部分
    public  bool 塗鴉手動畫出現1 = false; //C1-P變數部分
    public  bool 伯已對話, 給錢買筆後 = false; //C1-G變數部分
    public  bool 冊被搶=false;

    public void Awake()
    {
        
    }

    public void Start()
    {
        
    }
    
}
