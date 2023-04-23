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
    public static bool 塗鴉手動畫出現1,冊被搶,冊被搶過 = false; //C1-P變數部分
    public static bool 伯已對話,拿到錢買筆,有筆 = false; //C1-G變數部分
    //備忘錄
    public static bool C1Note,C2Note,C3Note,C3Note2=false;
    //BGM
    public static bool IsBgmReady = false;
    public static bool IsBgmReady02 = false;
    public static bool IsBgmReady03 = false;
    public static bool IsBgmReady04 = false;
    public static bool BGMstop=false;
    public static bool 第一章BGM結束,第二章BGM結束,第三章BGM結束=false;
    public static bool 第一章, 第二章, 第三章 = false;
    //C2變數
    public static bool 中卓走美教動畫已經播過,和小老師對話,拿到水彩筆,拿到水彩顏料,中卓離開,掀開畫布,補完畫 = false; //C2-NC
    public static bool 走過走廊,進過美術教室,找到水彩紙,找過布告欄 =false;//C2-C
    public static bool 第一次對話,第一次對話完,第二次對話,第二次對話完, 第三次對話,第三次說完, 拿到作業簿;//C2-TO
    public static bool 填色遊戲開始, 填色遊戲完成, 電話響,找過置物櫃;//C2-AC
    
    
    //C3變數

    public static bool 婆婆出去後,C3填色遊戲中,C3填色遊戲完成,事件完成,辭職信,電話,電話響過=false;


}
