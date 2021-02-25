using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rootmotion : MonoBehaviour
{
    public float moveSpeed = 1000f;
    public float turnSpeed = 90000f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.RightArrow))
        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);

          if (Input.GetKey(KeyCode.UpArrow))
        transform.Rotate(Vector3.left, -turnSpeed * Time.deltaTime);
        
        if (Input.GetKey(KeyCode.DownArrow))
        transform.Rotate(Vector3.left, turnSpeed * Time.deltaTime);
    }
}

