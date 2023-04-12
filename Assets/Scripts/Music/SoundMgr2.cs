using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundMgr2 : MonoBehaviour
{
    public static SoundMgr2 instance2;
    public AudioSource audioSource;

    public AudioMixer audioMixer;

    public AudioClip Bgm01;
    public AudioClip Bgm02;
    public AudioClip Bgm03;
    public AudioClip Bgmend;

    void Start()
    {
        
    }
    private void Awake()
    {
        instance2 = this;
    }

    void Update()
    {
        
    }

    public void PlayBgm01()
    {
        audioSource.clip = Bgm01;
        audioSource.Play();
    }
    public void PlayBgm02()
    {
        audioSource.clip = Bgm02;
        audioSource.Play();
    }
    public void PlayBgm03()
    {
        audioSource.clip = Bgm03;
        audioSource.Play();
    }
    public void PlayBgmend()
    {
        audioSource.clip = Bgmend;
        audioSource.Play();
    }
}
