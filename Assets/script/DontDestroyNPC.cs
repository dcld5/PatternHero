using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroyNPC : MonoBehaviour
{
    private static DontDestroyNPC instance;
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            
           // if (SceneManager.GetActiveScene().buildIndex == 0 || SceneManager.GetActiveScene().buildIndex == 4)
            //{
           //     Destroy(gameObject);
           // } else
           // {
                instance = this;
                DontDestroyOnLoad(transform.gameObject);
           // }
            
        }
        
    }
}
