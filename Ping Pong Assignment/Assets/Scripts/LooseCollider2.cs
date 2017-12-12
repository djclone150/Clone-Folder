using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LooseCollider2 : MonoBehaviour
{
    private LevelManager levelManager;
    static int playerScoreRight = 0;
    public Text scoreRight;


    void OnCollisionEnter2D(Collision2D collision)
    {
        //print("Collision with: " + collision.gameObject.name);
    }

    //works when Collider is Trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //print("Triggered with: " + collision.gameObject.name);
        playerScoreRight += 1;
        print("Right Player Score: " + playerScoreRight);
        if (playerScoreRight == 3)
        {
            print("Right player won this round!");
            levelManager.LoadLevel("Level3");
        }
        else
            levelManager.LoadLevel("Level2");


    }

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();

    }

    void Update()
    {
        scoreRight.text = playerScoreRight.ToString();
    }


}

