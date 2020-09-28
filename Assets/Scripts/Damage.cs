using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)//colisión de proyectil enemigo con usuario
    {
        GameControlScript.health--;
    }
   
}
