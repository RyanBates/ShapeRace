﻿using UnityEngine;
using System.Collections;

public class P1 : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {

        float h = Input.GetAxis("Horizontal") * speed;
        float v = Input.GetAxis("Vertical") * speed;

        gameObject.transform.position += -transform.right * (v * (1.5f * Time.deltaTime));

        gameObject.transform.localEulerAngles = new Vector3(0f,
        transform.eulerAngles.y + ((h * speed) * Time.deltaTime), 0f);
        transform.Rotate(Vector3.right, (speed * h) * Time.deltaTime);
    }
}