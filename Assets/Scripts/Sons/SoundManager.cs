﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{
    private float cooldown = 5;
    private float lastTime;
    [SerializeField] private AudioMixer audioMixer;

    void Start()
    {
        lastTime = Time.time;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (Time.time > cooldown + lastTime)
        {
            //lastTime = Time.time;
            //audioMixer.FindSnapshot("Accords").TransitionTo(40);
            //Debug.Log("Transition");
        }
    }


}