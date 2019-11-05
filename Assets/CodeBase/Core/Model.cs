﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    [HideInInspector]
    public static Model instance;
    [HideInInspector]
    public CheckPoint currentCheckpoint { get; private set; }


    public AudioManager audioManager;
    public AudioProfile globalAudio;
    
    private void Awake()
    {
        if(instance == null)
        {
            DontDestroyOnLoad(gameObject);
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);

        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        //TEMP WILL FIX AFTER DEMO
        currentCheckpoint =  GameObject.FindGameObjectWithTag("CheckPoint").GetComponent<CheckPoint>();

        audioManager.LoadProfile(globalAudio);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
