using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{

    
    public GameObject enemy;
    private bool var = false;
    private int xPos;
    private int zPos;

    //public Text scoreText;
    public static int ScoreValue=0;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Algo entro");
        
        Destroy(enemy); //Se destruye el enemigo que ha sido tocado por el proyectil      
        ScoreValue += 1;
        Debug.Log("el score actual es"+ScoreValue);
        var = true;
        if(var == true)
        {
            //Dentro de este if creamos un nuevo enemigo siguiendo la logica de EnemySpawn
            xPos = Random.Range(-3, 3);
            zPos = Random.Range(-3, 3);
            
            
            
            Instantiate(enemy, new Vector3(xPos, 0, zPos+5), Quaternion.identity);
            
        }
        
    }
    void Start()
    {
        ScoreValue = 0;
    }

    // Update is called once per frame
    
}
