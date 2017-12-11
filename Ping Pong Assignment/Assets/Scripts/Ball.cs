using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Ball : MonoBehaviour {
    private bool hasStarted = false;

    // Use this for initialization
    void Start () {
        
           
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("pressed");
            hasStarted = true;

        }

        int rand = Random.Range(0, 2);
        if (hasStarted == true)
        {
            hasStarted = false;
            Debug.Log("Pressed left click");
            if (rand == 0)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(-6f, -5f);
            }
            else if (rand == 1)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(6f, 5f);
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D hit)
    {
        float dist = this.transform.position.y - GameObject.Find("RightPaddle").transform.position.x;
        print(dist);
        
    }
}
