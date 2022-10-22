using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.Audio;
using System;

// 音量管理クラス
[Serializable]
public class Sound
{
    public string soundName;
    [Range(0f, 1f)]
    public float volume = 1;
    [Range(0.1f, 3f)]
    public float pitch;
    public AudioClip SEclip;
    public AudioClip BGMclip;
    public bool loop;
    //
    [HideInInspector]
    public AudioSource source;
    //
    public void Init()
    {
        
    }
}
public class SoundManager : MonoBehaviour
{

    public static SoundManager _instance;
    public Sound[] Sounds;

    void Awake()
    {
        //if(_instance = null)
        //{
        //    _instance = this;
        //}
        //else
        //{
        //    Destroy(gameObject);
        //    return;
        //}
        // 音管理はシーン遷移では破棄させない
        DontDestroyOnLoad(gameObject);
        foreach (Sound s in Sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.BGMclip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    private void Start()
    {
        PlayAnySound("BGmTest");
    }
    void PlayAnySound(string name)
    {
        Sound s = Array.Find(Sounds, sound => sound.soundName == name);
        if (s == null)
        {
            Debug.LogWarning("Sound " + name + " Not found!");
            return;
        }
           
        s.source.Play();
    }
}