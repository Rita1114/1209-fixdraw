using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundMgr : MonoBehaviour
{
    public static SoundMgr instance;
    public AudioSource audioSource;
    public AudioSource BGMaudioSource;
    public AudioClip BGM01;
    public AudioClip CircleSound;
    public AudioClip PenCircleSound;
    public AudioClip OpenBook;
    public AudioClip ClossBook;
    public AudioClip TurnPages;
    public AudioClip RingRing;
    public AudioClip RingEnd;

    public AudioMixer audioMixer;
    //public AudioMixer SoundEffectMixer;
    

    void Start()
    {
     
    }
    private void Awake()
    {
        instance = this;
    }
    public void CirclesoundEffect()
    {
        audioSource.clip = CircleSound;
        audioSource.Play();
    }
    public void PlayPenCirclesoundEffect()
    {
        audioSource.clip = PenCircleSound;
        audioSource.Play();
    }
    public void PlayOpenBook()
    {
        audioSource.clip = OpenBook;
        audioSource.Play();
    }
    public void PlayClossBook()
    {
        audioSource.clip = ClossBook;
        audioSource.Play();
    }
    public void PlayTurnPages()
    {
        audioSource.clip = TurnPages;
        audioSource.Play();
    }
     
    public void PlayRingRing()
    {
        audioSource.clip = RingRing;
        audioSource.Play();
    }
    public void PlayRingEnd()
    {
        audioSource.clip = RingEnd;
        audioSource.Play();
    }
    public void Bgm01()
    {
        
        BGMaudioSource.clip = BGM01;
        BGMaudioSource.Play();
        
    }
}
