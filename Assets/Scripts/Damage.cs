using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//colisión de proyectil enemigo con usuario
    {
        GameObject thePlayer = GameObject.Find("OVRPlayerController");//reemplaza objeto por el objeto que contenga el script

        GameControlScript hp = thePlayer.GetComponent<GameControlScript>();
        hp.health -= 1;
    }
   
}
