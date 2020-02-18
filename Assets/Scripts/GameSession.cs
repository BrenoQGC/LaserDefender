using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    public static GameSession Instance { get; private set; }

    public int score = 0;

    private void Awake()
    {
     if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public int GetScore()
    {
        return GameSession.Instance.score;
    }

    public void AddToScore(int scoreValue)
    {
        // GameSession.Instance.score += scoreValue;
        score += scoreValue;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
   /* private void Update()
    {
        Debug.Log(gameObject.GetInstanceID());
    }*/
}