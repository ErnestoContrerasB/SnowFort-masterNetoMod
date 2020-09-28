using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlScript : MonoBehaviour
{/// <summary>
/// Este Código esta amarrado al objeto vacio Game Control
/// </summary>
    public GameObject Heart1, Heart2, Heart3, GameOver;//las tres imagenes de corazón y la de gameover
    public  static int health;

    // Start is called before the first frame update
    void Start()//empezamos el juego con tres corazones y sin gameover
    {

        health = 3;
        Heart1.gameObject.SetActive(true);
        Heart2.gameObject.SetActive(true);
        Heart3.gameObject.SetActive(true);
        GameOver.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()//aqui vamos a estar checando si hubo algún cambio
    {
        if (health > 3)
            health = 3;//no tenemos items de sanación así que puede que sobre pero esto es para no pasarse de heals

        switch(health)//ahora si checamos los cambios de health
        {
            case 3://todo cool
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(true);
                break;
            case 2:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(true);
                Heart3.gameObject.SetActive(false);//perdimos un corazón
                break;
            case 1:
                Heart1.gameObject.SetActive(true);
                Heart2.gameObject.SetActive(false);//perdimos dos corazones
                Heart3.gameObject.SetActive(false);
                break;
            case 0:
                Heart1.gameObject.SetActive(false);
                Heart2.gameObject.SetActive(false);
                Heart3.gameObject.SetActive(false);
                GameOver.gameObject.SetActive(true);//gameover
                break;

        }
    }
}
