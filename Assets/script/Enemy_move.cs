using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_move : MonoBehaviour
{
    //menunjuk diri sendiri
    public GameObject toDestroy;

    public float speed;

    public bool moveRight;

    //public QuizManager qm;
    private Scene scene;
    
    // Update is called once per frame
    void Update()
    {
        if (moveRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-1, 1);
        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(1 ,1);

        }
    }

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("TurningPoint"))
        {
            if (moveRight)
            {
                moveRight = false;
            } else
            {
                moveRight = true;
            }
        }

        //pindah ke scene quiz
        if (trig.gameObject.CompareTag("Player"))
        {
            //pausing platformer game
            //Time.timeScale = 0f;
            /*if (scene.name == "Main Level")
            {
                Time.timeScale = 0f;
            } else
            {
                Time.timeScale = 1f;
            }*/

            //scene nya di timpa pakai scene quiz
            //DontDestroyOnLoad(GameObject.FindGameObjectWithTag("NPC"));
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1, LoadSceneMode.Additive);\
            speed = 0;

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            PlayerPrefs.SetInt("trueCounter", 0);
            PlayerPrefs.SetInt("falseCounter", 0);

            DestroyEnemy();
           
        }
    }

    public void DestroyEnemy()
    {
        Destroy(toDestroy);
    }


}
