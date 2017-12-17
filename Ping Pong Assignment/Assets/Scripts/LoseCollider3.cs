using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseCollider3 : MonoBehaviour
{
    private LevelManager myLevelManager;
    static int playerScoreLeft = 0;
    public Text scoreLeft;
    public static int redScore;
    public static int blueScore;


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
        if (playerScoreLeft == 7)
        {
            print("Red Player has won this round!");
            redScore++;
            //PersistentManagerScript.Instance.value++;
            playerScoreLeft = 0;
            myLevelManager.LoadLevel("Lose");
        }
        else
            myLevelManager.LoadLevel("Level3");


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
