using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LastScore : MonoBehaviour
{
    public Text LastScoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        LastScoreText.text = Enemy.ScoreValue.ToString();
    }



}
