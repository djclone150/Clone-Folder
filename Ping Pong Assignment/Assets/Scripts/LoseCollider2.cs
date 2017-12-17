using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseCollider2 : MonoBehaviour
{
    private LevelManager myLevelManager;
    static int playerScoreLeft = 0;
    public Text scoreLeft = null;

    //public GameObject loseColliderRight;

    //private LooseCollider otherScriptToAccess;

    //private int integerrScriptTwo;
    //private int integerScriptTwo;

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
        if (playerScoreLeft == 5)
        {
            print("Red Player has won this round!");
            playerScoreLeft = 0;
            //PersistentManagerScript.Instance.value++;
            myLevelManager.LoadLevel("Level3");
        }
        else
            myLevelManager.LoadLevel("Level2");


    }

    void Start()
    {
        myLevelManager = GameObject.FindObjectOfType<LevelManager>();

        //otherScriptToAccess = loseColliderRight.GetComponent<LooseCollider>();

        //integerrScriptTwo = otherScriptToAccess.redScoreSystem;
        //integerScriptTwo = otherScriptToAccess.blueScoreSystem;

        //Debug.Log(integerrScriptTwo);
        //Debug.Log(integerScriptTwo);

    }

    void Update()
    {
        scoreLeft.text = playerScoreLeft.ToString();
    }

}
