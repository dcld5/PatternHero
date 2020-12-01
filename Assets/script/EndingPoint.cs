using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingPoint : MonoBehaviour
{
    public LevelLoader LD;
    public GameObject destroy;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("ScoreSementara", ScoreScript.scoreValue);

            //destroy.GetComponent<DontDestroyNPC>().enabled = false;

            //StartCoroutine(LD.LoadLevel(SceneManager.GetActiveScene().buildIndex + 3));
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);

            Destroy(destroy);
        }
        
    }
}
