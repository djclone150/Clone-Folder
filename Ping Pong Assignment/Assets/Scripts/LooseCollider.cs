﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseCollider : MonoBehaviour {
    public LevelManager levelManager;
    static int playerScoreLeft = 0;


    void OnTriggerEnter2D(Collider2D collider)//this is triggered when a trigger is set
    {
        print("Trigger");
        playerScoreLeft += 1;
        print(playerScoreLeft);
        levelManager.LoadLevel("Lose"); //loads Win Scene ball enteres trigger
        
    }

    void OnCollisionEnter2D(Collision2D collision)//this is triggered when a collision happens
    {
        print("Collision");
        

        //levelManager.LoadLevel("Lose");
    }
}
