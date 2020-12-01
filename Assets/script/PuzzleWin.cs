using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleWin : MonoBehaviour
{
    //public GameObject enableHealth;
    public LevelLoader LD;
    private int pointsToWin;
    private int currentPoint;
    public GameObject myFruit;
    void Start()
    {
        pointsToWin = myFruit.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoint >= pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            IEnumerator TransitionToNextScene()
            {
                yield return new WaitForSeconds(1f);
                
                StartCoroutine(LD.LoadLevel(SceneManager.GetActiveScene().buildIndex - 2));
            }

            StartCoroutine(TransitionToNextScene());
            //enableHealth.SetActive(true);
            //ScoreScript.scoreValue += 250;
        }
    }

    public void AddPoint()
    {
        currentPoint++;
        ScoreScript.scoreValue += 200;
    }
}
