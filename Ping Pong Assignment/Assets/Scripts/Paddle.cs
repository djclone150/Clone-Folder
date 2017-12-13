    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //print(Input.mousePosition.y / Screen.height * 8); //this should print in the console the position of the cursor
        
        float mousePosInBlocks = (Input.mousePosition.y / Screen.height * 8) -4.5f;
        float mousePos = Mathf.Clamp(mousePosInBlocks, -4.1f, 4.1f);
        //float mousePos = Mathf.Clamp(mousePosInUnits, -5.9f, 5.9f);

        Vector3 paddlePosition = new Vector3(6f, this.transform.position.y, -0.3f);

        paddlePosition.y = mousePos;

        this.transform.position = paddlePosition;

        



    }
}
