using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int rand = Random.Range(0, 2);

        if (rand == 0)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-6f, 0f);
        }
        else if (rand == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(6f, 0f);
        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D hit)
    {
        float dist = this.transform.position.y - GameObject.Find("RightPaddle").transform.position.x;
        print(dist);
        
    }
}
