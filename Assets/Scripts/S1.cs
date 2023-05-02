using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class S1 : MonoBehaviour
{
    //private S3 S3;
    //
    public SoundMgr SoundMgr;
    public AudioMgr AudioMgr;
    public Button Startbutton;
    public Button Chapterbutton;
    public Button Setupbutton;
    public Button Leavebutton;
    
    //
    public Button BackMenu;

    public GameObject GameSetting;
    public GameObject GetProps;
    public GameObject Allbutton;
    private bool isopen = false;
    //
    public Slider BGMSlider2;
    //public float BGMvalue;
    

    void Start()
    {
        Startbutton.onClick.AddListener(StartGame);
        Chapterbutton.onClick.AddListener(ChooseChapter);
        Setupbutton.onClick.AddListener(GameSetup);
        Leavebutton.onClick.AddListener(LeaveGame);
        BackMenu.onClick.AddListener(Backmenu);
        //
        //S3 = GetComponent<S3>();
    }

    
    void Update()
    {
        //BGMvalue= BGMSlider2.value;
        //BGMSlider2.value;
        
        
    }
    public void Backmenu()
    {
        GameSetting.SetActive(false);
        GetProps.SetActive(false);
        Allbutton.SetActive(true);
    }
    public void StartGame()
    {
        SoundMgr.instance.CirclesoundEffect();
        SceneManager.LoadScene("S2");
        // GameMgr.�Ĥ@��BGM���� = false;
        //GameMgr.�ĤG��BGM���� = false;
        //GameMgr.�ĤT��BGM���� = false;
    }
    public void ChooseChapter()
    {
        SoundMgr.instance.CirclesoundEffect();
        GetProps.SetActive(true);
        Allbutton.SetActive(false);
    }
    public void GameSetup()
    {
        SoundMgr.instance.CirclesoundEffect();
        //isopen = true;
        GameSetting.SetActive(true);
        Allbutton.SetActive(false);
        /*if (isopen)
        {
            GameSetting.SetActive(true);
        }*/
    }
    public void LeaveGame()
    {
        SoundMgr.instance.CirclesoundEffect();
        Application.Quit();
    }

    
}
