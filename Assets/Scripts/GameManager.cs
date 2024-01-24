﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager thisManager = null;  
    
    [SerializeField] private Text Txt_Message = null;
    private int Score = 1;
    

    

    void Start()
    {
        thisManager = this;
        Time.timeScale = 0;
    }

    void Update()
    {
        if (Time.timeScale == 0 && Input.GetKeyDown(KeyCode.Return))
            StartGame();
    }

    public void UpdateScore(int value)
    {
        
        Score += value;
       
    }

    private void StartGame()
    {
        Score = 0;
        Time.timeScale = 1;
        Txt_Message.text = "";
        
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        Txt_Message.text = "GAMEOVER! \nPRESS ENTER TO RESTART GAME.";
        Txt_Message.color = Color.red;
    }
}
