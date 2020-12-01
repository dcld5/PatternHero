using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public Text score;
    public GameObject rekor;
    // Start is called before the first frame update
    void Start()
    {
        score.text = PlayerPrefs.GetInt("ScoreSementara", 0).ToString();

        if (PlayerPrefs.GetInt("ScoreSementara") > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", PlayerPrefs.GetInt("ScoreSementara"));
            rekor.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
