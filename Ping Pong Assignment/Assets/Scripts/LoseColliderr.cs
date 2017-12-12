using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseColliderr : MonoBehaviour {
    private LevelManager myLevelManager;
    static int playerScoreLeft = 0;
    public Text scoreLeft;


    void OnCollisionEnter2D(Collision2D collision)
    {
        //print("Collision with: " + collision.gameObject.name);
    }

    //works when Collider is Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("Triggered with: " + collision.gameObject.name);
        playerScoreLeft += 1;
        print("Left Player Score: " + playerScoreLeft);
        if (playerScoreLeft == 3)
        {
            print("Left Player has won this round!");
            myLevelManager.LoadLevel("Level2");
        }
        else
            myLevelManager.LoadLevel("Level1");

        
    }

    void Start()
    {
        myLevelManager = GameObject.FindObjectOfType<LevelManager>();

    }

    void Update()
    {
        scoreLeft.text = playerScoreLeft.ToString();
    }

}
