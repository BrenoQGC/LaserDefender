﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    int score=0;

    private void Awake()
    {
        SetupSingleton();
    }

    private void SetupSingleton()
    {
        int sessionNumber = FindObjectsOfType<GameSession>().Length;
        if (sessionNumber > 1)
        {
            Destroy(gameObject);
            Debug.Log("Game Session Destruido");
            Debug.Log(sessionNumber);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        } 
    }

    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreValue)
    {
        score += scoreValue;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
