using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject pause;
    bool Paused = false;

    void Start()
    {
        pause.gameObject.SetActive(false);
    }

    void Update() 
    {
        if (Input.GetKeyDown ("escape"))
        {
            if(Paused == true)
            {
                Time.timeScale = 1.0f;
                pause.gameObject.SetActive (false);
                Paused = false;
            }
            else 
            {
                Time.timeScale = 0.0f;
                pause.gameObject.SetActive (true);
                Paused = true;
            }
        }
    }
}