using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

    private Vector2 posA;

    private Vector2 posB;

    private Vector2 nextPos;

    [SerializeField]
    private float speed;

    [SerializeField]
    private Transform childTransform;

    
    [SerializeField]
    private Transform transformB;




	// Use this for initialization
	void Start () {
        posA = childTransform.localPosition;
        posB = transform.localPosition;
        nextPos = posB;
		
	}
	
	// Update is called once per frame
	void Update () {
        Move();
	}

    private void Move()
    {
        childTransform.localPosition = Vector2.MoveTowards(childTransform.localPosition, nextPos, speed * Time.deltaTime);
        if (Vector2.Distance(childTransform.localPosition, nextPos) <= 0.1)
        {
            changeDest();
        }    

    }

    private void changeDest()
    {
        nextPos = nextPos != posA ? posA : posB;
    }
}
