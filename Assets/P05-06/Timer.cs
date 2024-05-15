using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private GameObject M_Lose;
    private float timerTime;
    private int min, sec, cent;
    public int limite = 600; 

    // Update is called once per frame
    void Update()
    {

        if (timerTime < limite)
        {
            timerTime += Time.deltaTime;
        }
        else
        {
            Time.timeScale = 0.0f;
            M_Lose.SetActive(true);
        }
        min = (int)(timerTime/60);
        sec = (int)(timerTime - min*60);
        cent = (int)((timerTime - (int)timerTime)*100);
        timerText.text = string.Format("{0:00}:{1:00}:{2:00}", min, sec, cent);
    }
    public void reiniciar()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
