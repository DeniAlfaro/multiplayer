using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MLAPI;
public class Timer : MonoBehaviour
{
    public Text txtScoreResultado;
    public float timerValue = 90;
    public Text timerText;
    public GameObject gameOverPanel;
    public Text scoreGO;
    public static int theScore;
    //public AudioSource gameMusic;

    [SerializeField]
    public GameObject score;

    void Update()
    {
        if (timerValue > 0)
        {
            //gameMusic.Play();
            timerValue -= Time.deltaTime;
        }
        else
        {
            timerValue = 0;
        }
        if (timerValue == 0)
        {
            gameOverPanel.SetActive(true);            
            Time.timeScale = 0f;
            txtScoreResultado.text = score.GetComponent<Text>().text;
        }
        DisplayTime(timerValue);
    }
  

    void DisplayTime(float timerToDisplay) {
        if (timerToDisplay < 0)
        {
            timerToDisplay = 0;
        }
        float minutes = Mathf.FloorToInt(timerToDisplay / 60);
        float seconds = Mathf.FloorToInt(timerToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
