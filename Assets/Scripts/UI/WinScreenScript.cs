using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScreenScript : MonoBehaviour
{
    public Text winText;
    private float secondsCount;
    private int minutesCount;
    bool stoptimer = false;
    public GameObject win;
    public GameObject MainUI;
    // Start is called before the first frame update
    void Update()
    {
        WinTimer();
    }

    // Update is called once per frame
    public void WinTimer()
    {
        if (!stoptimer)
        {
            secondsCount += Time.deltaTime;


            winText.text = "Time completed on: " + minutesCount + "m:" + (int)secondsCount + "s";
            if (secondsCount >= 60)
            {
                minutesCount++;
                secondsCount = 0;
            }
        }
        else
        {
            winText.text = "Time completed on: " + minutesCount + "m:" + (int)secondsCount + "s";
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Finished"))
        {
            Destroy(coll.gameObject);
            stoptimer = true;
            win.gameObject.SetActive(true);
            MainUI.gameObject.SetActive(false);
            Invoke("MainMenuLoad", 5f);
        }
    }

    private void MainMenuLoad()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
