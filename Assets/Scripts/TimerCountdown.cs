using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerCountdown : MonoBehaviour
{
    public GameObject textDisplay;
    public int secondsLeft = 180;
    public bool takingAway = false;
 

    void Start()
    {
        textDisplay.GetComponent<Text>().text = secondsLeft+" s";
    }
    private void Update()
    {
        if (takingAway == false && secondsLeft >0)
        {
            StartCoroutine(TimerTake());
        }
    }

    IEnumerator TimerTake()
    {
        
        takingAway = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;


        if (secondsLeft < 10)
        {
            textDisplay.GetComponent<Text>().color = Color.red;
            textDisplay.GetComponent<Text>().text = "0"+secondsLeft+" s";
        }
        else
        {
            textDisplay.GetComponent<Text>().text =secondsLeft+" s";
        }
        takingAway = false;

        if(secondsLeft==0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
