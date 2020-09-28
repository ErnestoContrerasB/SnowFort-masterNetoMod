using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Enemy : MonoBehaviour
{


    public GameObject enemy;
    private bool var = false;
    private int randomN;
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
            randomN = Random.Range(1, 6);
            Debug.Log(randomN);

            switch (randomN)
            {
                case 1:
                    Debug.Log("caso 1");
                    Instantiate(enemy, new Vector3(5, 0, 0), Quaternion.Euler(new Vector3(0, -90, 0)));
                    Instantiate(enemy, new Vector3(5, 0, 5), Quaternion.Euler(new Vector3(0, 40, 0)));
                    break;
                case 2:
                    Debug.Log("caso 2");
                    Instantiate(enemy, new Vector3(-5, 0, 5), Quaternion.Euler(new Vector3(0, 90, 0)));
                    Instantiate(enemy, new Vector3(-5, 0, -5), Quaternion.Euler(new Vector3(0, 120, 0)));
                    break;
                case 3:
                    Debug.Log("caso 3");
                    Instantiate(enemy, new Vector3(0, 0, 5), Quaternion.Euler(new Vector3(0, -0, 0)));
                    Instantiate(enemy, new Vector3(0, 0, -5), Quaternion.Euler(new Vector3(0, 40, 0)));
                    break;
                case 4:
                    Debug.Log("caso 4");
                    Instantiate(enemy, new Vector3(5, 0, -5), Quaternion.Euler(new Vector3(0, -40, 0)));
                    Instantiate(enemy, new Vector3(-5, 0, 0), Quaternion.Euler(new Vector3(0, 40, 0)));
                    break;
                case 5:
                    Debug.Log("caso 5");
                    Instantiate(enemy, new Vector3(-3, 0, 7), Quaternion.Euler(new Vector3(0, -90, 0)));
                    Instantiate(enemy, new Vector3(3, 0, -7), Quaternion.Euler(new Vector3(0, 40, 0)));
                    break;
                case 6:
                    Debug.Log("caso6");
                    Instantiate(enemy, new Vector3(3, 0, 7), Quaternion.Euler(new Vector3(0, -90, 0)));
                    Instantiate(enemy, new Vector3(-3, 0, -7), Quaternion.Euler(new Vector3(0, 40, 0)));
                    break;
                case 7:
                    Debug.Log("caso 7");
                    //Instantiate(enemy, new Vector3(5, 0, 0), Quaternion.Euler(new Vector3(0, -90, 0)));
                    //Instantiate(enemy, new Vector3(5, 0, 5), Quaternion.Euler(new Vector3(0, 40, 0)));
                    break;
                case 8:
                    Debug.Log("caso 8");
                    //Instantiate(enemy, new Vector3(5, 0, 0), Quaternion.Euler(new Vector3(0, -90, 0)));
                    //Instantiate(enemy, new Vector3(5, 0, 5), Quaternion.Euler(new Vector3(0, 40, 0)));
                    break;

            }

        }
        
    }
    void Start()
    {
        ScoreValue = 0;
    }

    // Update is called once per frame
    
}
