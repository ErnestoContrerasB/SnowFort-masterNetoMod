using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{/// <summary>
/// A mi parecer todo este código chiquito podría ir de una vez en el trigger de cuando se muere el enemigo
/// </summary>
/// 
/// 
    public Text scoreText;
    

void Update()
    {
        scoreText.text = Enemy.ScoreValue.ToString();
    }
    
    
}
