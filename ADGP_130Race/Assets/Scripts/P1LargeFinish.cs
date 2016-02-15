﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class P1LargeFinish : MonoBehaviour
{

    public bool finished = false;
    public GUIText timer;
    public float raceTime = 0.0f;

    void OnTriggerEnter()
    {
        finished = true;
    }

    void OnGUI()
    {
        if (finished == true)
        {
            GUI.Label(new Rect(Screen.width / 2, Screen.height / 2, 100, 20), "Finish!");
            if (GUI.Button(new Rect(10, 50, 300, 40), "Restart Game"))
            {
                SceneManager.LoadScene("P1 Large Track");
            }
            if (GUI.Button(new Rect(10, 100, 300, 40), "Back to Title Screen"))
            {
                SceneManager.LoadScene("Title Menu");
            }
            if (GUI.Button(new Rect(10, 150, 300, 40), "Exit Game"))
            {
                Application.Quit();
            }
        }
    }

    void Update()
    {
        if (finished == false)
        {
            raceTime = raceTime + 1 * Time.deltaTime;
            timer.text = raceTime.ToString("f2");
        }
    }
}
