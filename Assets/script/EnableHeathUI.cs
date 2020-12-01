using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnableHeathUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enableHeath;
    void Start()
    {
        //SceneManager.sceneLoaded += OnSceneLoaded;
        //ScoreScript.scoreValue = 0;
        //Debug.Log("Score Reset");
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }


    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if(SceneManager.GetActiveScene().buildIndex == 1)
        {
            enableHeath.SetActive(true);
            Debug.Log("Health Enabled");
        } else
        {
            enableHeath.SetActive(false);
        }
        
    }
}
