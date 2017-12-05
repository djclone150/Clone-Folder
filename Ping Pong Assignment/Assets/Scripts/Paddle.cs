using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        print(Input.mousePosition.x / Screen.width * 8); //this should print in the console the position of the cursor
        float mousePosInBlocks = (Input.mousePosition.x / Screen.width * 8) -4f;

        Vector3 paddlePosition = new Vector3(0.5f, this.transform.position.y, 0);

        this.transform.position = paddlePosition;

        paddlePosition.x = mousePosInBlocks;



    }
}
