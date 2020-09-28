using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//importante poner este porque sin esto no se pueden pasar values al canvas

public class ScoreControlScript : MonoBehaviour
{
    public Text scoreText ;
    public static int ScoreValue =0 ;
    // Start is called before the first frame update
    void Start()
    {
        ScoreValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ScoreValue.ToString();
    }
}
