using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseColliderr : MonoBehaviour
{

    public LevelManager levelManager;
    static int playerScoreRight = 0;


    void OnTriggerEnter2D(Collider2D collider)//this is triggered when a trigger is set
    {
        print("Trigger");
        playerScoreRight += 1;
        print(playerScoreRight);
        levelManager.LoadLevel("Lose"); //loads Win Scene ball enteres trigger
        
    }

    void OnCollisionEnter2D(Collision2D collision)//this is triggered when a collision happens
    {
        print("Collision");
        

        //levelManager.LoadLevel("Lose");
    }
}