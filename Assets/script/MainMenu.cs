using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public LevelLoader LD;
    public bool GameIsPaused = false;
    // public AudioManager audiomanager;
    //public Text highScore;


    private void Start()
    {
        //if (SceneManager.GetActiveScene().buildIndex == 0)
        {
        //    StartCoroutine(LD.LoadLevel(0));
        }
        
    }

    public void Update()
    {
        
        
    }
    public void PlayGame()
    {
        StartCoroutine(LD.LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
        Health.health = 3;
        ScoreScript.scoreValue = 0;
        //health reset
    }

    public void BackToMenu()
    {
        //StartCoroutine(LD.LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        //LD.transition.SetTrigger("Start");
        //StartCoroutine(LD.LoadLevel(0));
        Debug.Log("ke main menu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        //audiomanager.Pause("Theme");
        GameObject.Find("Controllers").GetComponent<AudioManager>().Pause("Theme");
        //GetComponent<AudioManager>().Pause("Theme");
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        GameIsPaused = false;
        //audiomanager.Resume("Theme");
        GameObject.Find("Controllers").GetComponent<AudioManager>().Resume("Theme");
        GetComponent<AudioManager>().Resume("Theme");
    }

    public void BackToMenuFromEnding()
    {
        StartCoroutine(LD.LoadLevel(SceneManager.GetActiveScene().buildIndex - 4));
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
