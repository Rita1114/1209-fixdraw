using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class S3 : MonoBehaviour
{
    public Slider BgmValue;//BGM拉條
    //
    public Button Workbookbutton;//右下作業本
    public GameObject Workbookhide;//右下作業本
    public GameObject Workbook;//打開的作業本
    public Button Closebookbutton;


    public Button Notebutton;//備忘錄按鈕
    public Button GameSettingbutton;//遊戲設置按鈕
    public Button BackMenu;//回到主菜單
    public GameObject Notecontent;//備忘錄內容
    public GameObject GameSeetingcontent;//遊戲設置內容
    public GameObject OldHouseThing;//老家裡的內容物品
    //更改備忘錄內容
    public GameObject NoteC1;
    public GameObject NoteC2;
    public GameObject NoteC3;
    public GameObject NoteC302;
    //Marks
    public Button RedMarkbutton;//紅色標籤
    public Button GreenMarkbutton;//綠
    public Button BlueMarkbutton;//藍
    public Button PurpleMarkbutton;//紫

    public GameObject rightRedMark;//又紅色標籤
    public GameObject leftsRedMark;//左紅色標籤
    //C1
    public Inventory MyBook;
    public Item Drawbook;
    public Item Pen;
    //C2
    public Item watercolorpen;
    public Item watercolorbox;
    public Item watercolorpaper;
    void Start()
    {
        
        Workbookbutton.onClick.AddListener(OpenWorkBook);
        Closebookbutton.onClick.AddListener(CloseWorkBook);
        Notebutton.onClick.AddListener(NoteContent); ;
        GameSettingbutton.onClick.AddListener(GameSettingContent);
        BackMenu.onClick.AddListener(ClickBackMenu);

        //GameMgr.IsBag = false;
        //Marks
        RedMarkbutton.onClick.AddListener(ClickRedMark);
    }

   
    void Update()
    {
        if (MyBook.itemlist.Contains(Pen) && MyBook.itemlist.Contains(Drawbook))
        {
            Destroy(NoteC1);
        }
        if (MyBook.itemlist.Contains(watercolorpen) && MyBook.itemlist.Contains(watercolorbox) && MyBook.itemlist.Contains(watercolorpaper))
        {
            Destroy(NoteC2);
        }
        if (GameMgr.C3Note)
        {
            Destroy(NoteC3);
        }
        if (GameMgr.C3Note2)
        {
            NoteC302.SetActive(true);
        }

    }
    #region 我的function
    void OpenWorkBook()
    {
        SoundMgr.instance.PlayOpenBook();
        Workbook.SetActive(true);
        Workbookhide.SetActive(false);
        Notecontent.SetActive(true);
        GameSeetingcontent.SetActive(false);
        rightRedMark.SetActive(true);
        leftsRedMark.SetActive(false);
        OldHouseThing.SetActive(false);

        
    }
    void CloseWorkBook()
    {
        SoundMgr.instance.PlayClossBook();
        Workbook.SetActive(false);
        Workbookhide.SetActive(true);
    }
    void NoteContent()
    {
        SoundMgr.instance.PlayTurnPages();
        Notecontent.SetActive(true);
        GameSeetingcontent.SetActive(false);
        rightRedMark.SetActive(true);
        leftsRedMark.SetActive(false);
        OldHouseThing.SetActive(false);
    }
    void GameSettingContent()
    {
        SoundMgr.instance.PlayTurnPages();
        GameSeetingcontent.SetActive(true);
        Notecontent.SetActive(false);
        rightRedMark.SetActive(true);
        leftsRedMark.SetActive(false);
        OldHouseThing.SetActive(false);
    }
    void ClickBackMenu()
    {
        SoundMgr.instance.CirclesoundEffect();
        SceneManager.LoadScene("S1");
        GameMgr.第一章BGM結束 = true;
        GameMgr.第二章BGM結束 = true;
        GameMgr.第三章BGM結束 = true;
    }
    //Marks
    void ClickRedMark()
    {
        SoundMgr.instance.PlayTurnPages();
        rightRedMark.SetActive(false);
        leftsRedMark.SetActive(true);
        Notecontent.SetActive(false);
        GameSeetingcontent.SetActive(false);
        OldHouseThing.SetActive(true);
    }
    #endregion
    

}
