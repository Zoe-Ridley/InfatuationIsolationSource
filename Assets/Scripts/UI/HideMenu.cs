using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideMenu : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject MainMenuUI;
    public int time;

    void OnEnable()
    {
        StartCoroutine (Hide ());
    }

    IEnumerator Hide()
    {
        Time.timeScale = 1.0f;
        yield return new WaitForSeconds (time);
        Canvas.SetActive (false);
        MainMenuUI.SetActive (true);
    }
}