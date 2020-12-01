using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public static int health = 3;
    public int munOfHeart;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    public GameObject destroy;

    private void Update()
    {
        if(health > munOfHeart)
        {
            health = munOfHeart;
        }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < health)
            {
                hearts[i].sprite = fullHeart;
            } else
            {
                hearts[i].sprite = emptyHeart;
            }

            if(i < munOfHeart)
            {
                hearts[i].enabled = true;
            } else
            {
                hearts[i].enabled = false;
            }
        }

        if (health == 0)
        {
            PlayerPrefs.SetInt("ScoreSementara", ScoreScript.scoreValue);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
            Destroy(destroy);
        }
    }
}
