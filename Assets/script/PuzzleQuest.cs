using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleQuest : MonoBehaviour
{
    //public Animator transition;
    //public GameObject disableCamera;
    public GameObject disableHealth;
    public GameObject player;

    public float transTime = 1f;

    public LevelLoader LD;
    public bool isDone = false;
    public GameObject toDestroy;

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if(isDone == false)
            {
                //StartCoroutine(LD.LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
                Debug.Log("go to puzzle");
                
                disableHealth.SetActive(false);
                Debug.Log("Health Disabled");

                isDone = true;
                Destroy(toDestroy);
                gameObject.GetComponent<PuzzleQuest>().enabled = false;
                //gameObject.SetActive(false);
                player.transform.localPosition = new Vector3(player.transform.localPosition.x - 3, player.transform.localPosition.y, player.transform.localPosition.z);

            }
                
        } 
        
    }

    
}
