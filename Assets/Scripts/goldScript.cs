using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class goldScript : MonoBehaviour
{
    public int gold; //la variable para el oro
    public Text goldT; //objeto tipo text para mostrar el oro
    Rigidbody rg; //Rigidbody




    public void OnTriggerEnter(Collider other)
    {
        //Al entrar en un trigger
        Debug.Log("Si hay dinero");
        gold = gold + 1;
        goldT.text = "Gold: " + gold;
    }

    public void Awake()
    {
        //La neta no recuerdo para que tanta mamada, deberia funcionar con el puro trigger
        rg = GetComponent<Rigidbody>();
        goldT.text = "puntos: " + gold;
    }

    private void Start()
    {
        goldT.text = "Gold:" + gold;
    }
}
