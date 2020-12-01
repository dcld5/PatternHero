using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using System.Runtime.Remoting.Metadata.W3cXsd2001;
//using System.Runtime.CompilerServices;

public class QuizManager : MonoBehaviour
{

    public LevelLoader LD;
    private Enemy_move EM;

    public Question[] questions;
    private static List<Question> unansweredQuestions;

    public int trueCounter; //= PlayerPrefs.GetInt("trueCounter");
    public int falseCounter; //= PlayerPrefs.GetInt("falseCounter");

    private Question currentQuestion;

    [SerializeField]
    private Text questionText;

    [SerializeField]
    private Text questionA;

    [SerializeField]
    private Text questionB;

    [SerializeField]
    private Text questionC;

    [SerializeField]
    private Text questionD;

    [SerializeField]
    private Text AnswerAText;

    [SerializeField]
    private Text AnswerBText;

    [SerializeField]
    private Text AnswerCText;

    [SerializeField]
    private Text AnswerDText;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float timeBetweenQuestions = 1f;

    

    void Start()
    {
        Debug.Log("REFRESH");
        trueCounter = PlayerPrefs.GetInt("trueCounter");
        falseCounter = PlayerPrefs.GetInt("falseCounter");
        //Debug.Log("Starting true = " + trueCounter);
        //Debug.Log("Starting false = " + falseCounter);

        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<Question>();
        }

        SetCurrentQuestion(); 

    }


    void SetCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        questionText.text = currentQuestion.question;
        questionA.text = currentQuestion.answerA;
        questionB.text = currentQuestion.answerB;
        questionC.text = currentQuestion.answerC;
        questionD.text = currentQuestion.answerD;

        /*if (currentQuestion.isA)
        {
            AnswerAText.text = "BENAR";
            AnswerBText.text = "SALAH";
            AnswerCText.text = "SALAH";
            AnswerDText.text = "SALAH";
        } else if (currentQuestion.isB)
        {
            AnswerAText.text = "SALAH";
            AnswerBText.text = "BENAR";
            AnswerCText.text = "SALAH";
            AnswerDText.text = "SALAH";
        }
        else if (currentQuestion.isC)
        {
            AnswerAText.text = "SALAH";
            AnswerBText.text = "SALAH";
            AnswerCText.text = "BENAR";
            AnswerDText.text = "SALAH";
        }
        else if (currentQuestion.isD)
        {
            AnswerAText.text = "SALAH";
            AnswerBText.text = "SALAH";
            AnswerCText.text = "SALAH";
            AnswerDText.text = "BENAR";
        }*/

    }

    IEnumerator TransitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        
        
        if (trueCounter >= 3 || falseCounter >= 3)
        {
            //if (EM != null)
            //{
            //    EM.DestroyEnemy();
            //}
            Debug.Log("Back to main level scene");
            StartCoroutine(LD.LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            //SceneManager.UnloadScene(SceneManager.GetActiveScene().buildIndex);
            //EM.DestroyEnemy();
            

            if (trueCounter >= 3)
            {
                ScoreScript.scoreValue += 100;
                 
            }
            if (falseCounter >= 3)
            {
                Health.health -= 1;
                
            }

            Debug.Log("PINDAH");
            PlayerPrefs.SetInt("trueCounter", 0);
            PlayerPrefs.SetInt("falseCounter", 0);
        } else
        {
            //reload scene and change to next question
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            
        }
    }

    public void userSelectA()
    {
        //animator.SetInteger("WhatAnswer", 1);

        if (currentQuestion.isA)
        {
            trueCounter++;
            animator.SetTrigger("True");
            PlayerPrefs.SetInt("trueCounter", trueCounter);
            Debug.Log("true = " + trueCounter);
            Debug.Log("false = " + falseCounter);
        } else
        {
            falseCounter++;
            animator.SetTrigger("False");
            PlayerPrefs.SetInt("falseCounter", falseCounter);
            Debug.Log("true = " + trueCounter);
            Debug.Log("false = " + falseCounter);
        }

        StartCoroutine(TransitionToNextQuestion());
        //Debug.Log("coroutine");
    }

    public void userSelectB()
    {
        //animator.SetInteger("WhatAnswer", 2);

        if (currentQuestion.isB)
        {
            trueCounter++;
            animator.SetTrigger("True");
            PlayerPrefs.SetInt("trueCounter", trueCounter);
            Debug.Log("true = " + trueCounter);
            Debug.Log("false = " + falseCounter);
        }
        else
        {
            falseCounter++;
            animator.SetTrigger("False");
            PlayerPrefs.SetInt("falseCounter", falseCounter);
            Debug.Log("true = " + trueCounter);
            Debug.Log("false = " + falseCounter);
        }

        StartCoroutine(TransitionToNextQuestion());
        //Debug.Log("coroutine");
    }

    public void userSelectC()
    {
        //animator.SetInteger("WhatAnswer", 3);

        if (currentQuestion.isC)
        {
            trueCounter++;
            animator.SetTrigger("True");
            PlayerPrefs.SetInt("trueCounter", trueCounter);
            Debug.Log("true = " + trueCounter);
            Debug.Log("false = " + falseCounter);
        }
        else
        {
            falseCounter++;
            animator.SetTrigger("False");
            PlayerPrefs.SetInt("falseCounter", falseCounter);
            Debug.Log("true = " + trueCounter);
            Debug.Log("false = " + falseCounter);
        }

        StartCoroutine(TransitionToNextQuestion());
        //Debug.Log("coroutine");
    }

    public void userSelectD()
    {
        //animator.SetInteger("WhatAnswer", 4);

        if (currentQuestion.isD)
        {
            trueCounter++;
            animator.SetTrigger("True");
            PlayerPrefs.SetInt("trueCounter", trueCounter);
            Debug.Log("true = " + trueCounter);
            Debug.Log("false = " + falseCounter);
        }
        else
        {
            falseCounter++;
            animator.SetTrigger("False");
            PlayerPrefs.SetInt("falseCounter", falseCounter);
            Debug.Log("true = " + trueCounter);
            Debug.Log("false = " + falseCounter);
        }

        StartCoroutine(TransitionToNextQuestion());
       // Debug.Log("coroutine");
    }

}
