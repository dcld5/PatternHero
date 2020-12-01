using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        //menampilkan skor tertinggi
        //if (PlayerPrefs.GetInt("HighScore") != null)
        //{
            highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
