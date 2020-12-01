using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerSave
{
    public int score;
    public int healths;
    public float[] position;

    public PlayerSave(Health health)
    {
        healths = Health.health;

        //position = new float[3];
        //position[0] = GameObject.Find("Player").GetComponent<Transform>().position.x;
        //position[1] = GameObject.Find("Player").GetComponent<Transform>().position.y;
        //position[2] = GameObject.Find("Player").GetComponent<Transform>().position.z;
    }
}
