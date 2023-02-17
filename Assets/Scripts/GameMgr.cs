using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.Playables;
using UnityEngine.Timeline;


public static class GameMgr 
{
    
    public static bool IsBag = false;//�x�s�ܼƤ�k

    public static bool IsFirstTimeLinePlayed= false;
    public static bool IsGetpan =false;
    public static bool isChangeScene;
    
    public static GameObject player,drawgame;
    public static Flowchart flowchart;

    public static bool drawgameDone=false;
    
    public static string DebugSceneName;
    public static int startPointNumber; //換場景的點
    public static bool 拿到糖, 拿到錢 ,拿到筆,收集完= false; //C1-L變數部分
    public static bool 豬公已對話, 糖給豬公後,拿回冊 = false; //C1-C變數部分
    public static bool 塗鴉手動畫出現1,冊被搶 = false; //C1-P變數部分
    public static bool 伯已對話, 給錢買筆後,拿到錢買筆 = false; //C1-G變數部分

    
    //C2變數
    public static bool 中卓走美教動畫已經播過,和小老師對話,拿到水彩筆 = false; //C2-NC
    public static bool 走過走廊=false;//C2-C
    public static bool 第一次對話, 第二次對話, 第三次對話, 拿到作業簿;//C2-TO
    public static bool 填色遊戲開始, 填色遊戲完成, 電話響,找過置物櫃;//C2-AC

}
