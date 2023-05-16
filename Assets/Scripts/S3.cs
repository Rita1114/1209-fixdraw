using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Fungus;

public class S3 : MonoBehaviour
{
    public Slider BgmValue;//BGM�Ա�
    //
    public Button Workbookbutton;//�k�U�@�~��
    public GameObject Workbookhide;//�k�U�@�~��
    public GameObject Workbook;//���}���@�~��
    public Button Closebookbutton;


    public Button Notebutton;//�Ƨѿ����s
    public Button GameSettingbutton;//�C���]�m���s
    public Button BackMenu;//�^��D���
    public GameObject Notecontent;//�Ƨѿ����e
    public GameObject GameSeetingcontent;//�C���]�m���e
    public GameObject OldHouseThing;//�Ѯa�̪����e���~
    //���Ƨѿ����e
    public GameObject NoteC1;
    public GameObject NoteC2;
    public GameObject NoteC3;
    public GameObject NoteC302;
    //Marks
    public Button RedMarkbutton;//�������
    public Button GreenMarkbutton;//��
    public Button BlueMarkbutton;//��
    public Button PurpleMarkbutton;//��

    public GameObject rightRedMark;//�S�������
    public GameObject leftsRedMark;//���������
    //C1
    public Inventory MyBook;
    public Item Drawbook;
    public Item Pen;
    //C2
    public Item watercolorpen;
    public Item watercolorbox;
    public Item watercolorpaper;
    public Flowchart flowchart;
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
    #region �ڪ�function
    void OpenWorkBook()
    {
        flowchart.SetBooleanVariable("作業簿打開",true);
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
        flowchart.SetBooleanVariable("作業簿打開",false);
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
