using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //this code lets me call my gamemanager script from other scripts
    private static GameManager instance;
    public static GameManager Instance { get { return instance; } }

    //these are my variables that I have i want saved throughout the game
    
    //public int trueCounter = 0;
    /*public int falseCounter = 0;

    
    private void Awake()
    {
        instance = this;
        if (PlayerPrefs.HasKey("trueCounter") || PlayerPrefs.HasKey("falseCounter"))
        {
            trueCounter = PlayerPrefs.GetInt("trueCounter");
            falseCounter = PlayerPrefs.GetInt("falseCounter");
        } else
        {
            Save();
        }
    }

    public void Save()
    {
        PlayerPrefs.SetInt("trueCounter", trueCounter);
        PlayerPrefs.SetInt("falseCounter", falseCounter);
    }*/
}

