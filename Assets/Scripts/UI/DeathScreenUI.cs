using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathScreenUI : MonoBehaviour
{
    public Text DeathText;
    private float secondsCount;
    private int minutesCount;
    bool stoptimer = false;
    public GameObject death;
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


            DeathText.text = "Died in: " + minutesCount + "m:" + (int)secondsCount + "s";
            if (secondsCount >= 60)
            {
                minutesCount++;
                secondsCount = 0;
            }
        }
        else
        {
            DeathText.text = "Died in: " + minutesCount + "m:" + (int)secondsCount + "s";
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            Destroy(coll.gameObject);
            stoptimer = true;
            death.gameObject.SetActive(true);
            MainUI.gameObject.SetActive(false);
            Invoke("MainMenuLoad", 5f);
        }
    }

    private void MainMenuLoad()
    {
        SceneManager.LoadScene("MainLevel");
    }
}
