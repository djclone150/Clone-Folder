using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddler : MonoBehaviour
{
    public float speed = 1.5f;

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime * 7;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime * 7;
        }
    }



}
