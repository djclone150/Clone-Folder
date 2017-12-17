using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LooseCollider : MonoBehaviour {
    private LevelManager levelManager;
    static int playerScoreRight = 0;
    public Text scoreRight;
    public Text RedScore;
    public Text BlueScore;

    static int redScore = 0;
    static int blueScore = 0;

    //public bool myBooleanVariable = false;
    //public int redScoreSystem = 0;
    //public int blueScoreSystem = 0;

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
            print("Blue player won this round!");
            playerScoreRight = 0;
            //PersistentManagerScript.Instance.value++;
            //blueScoreSystem++;
            levelManager.LoadLevel("Level2");
        }
        else
            levelManager.LoadLevel("Level1");


    }

    void Start()
    {
        levelManager = GameObject.FindObjectOfType<LevelManager>();

    }

    void Update()
    {
        scoreRight.text = playerScoreRight.ToString();
        //RedScore.text = redScore.ToString();
        //BlueScore.text = blueScore.ToString();

    }


}
