﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpRotation : MonoBehaviour
{
    [SerializeField]  [Range(1f,1f)] float lerpTime;
    [SerializeField]  Vector3[]  myAngles;

    int angleIndex;
    int len;

    float t = 0f;

    void Start()
    {
        len = myAngles.Length;   
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.Euler (myAngles [angleIndex]),lerpTime*Time.deltaTime);

        t = Mathf.Lerp (t, 1f, lerpTime * Time.deltaTime);
        if (t>.9f){
            t = 0f;
            angleIndex = Random.Range (0, len - 1);
        }
    }
}
