using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snowScript : MonoBehaviour
{
    //public GameObject enemyPrefab;
    
    public int xPos; 
    public int zPos;
    public GameObject snow;
    public int snowCount;

    private void Start()
    {
        
        StartCoroutine(SnowDrop());
    }
    //private void FixedUpdate()
    IEnumerator SnowDrop()
    {
        while (snowCount < 5)
        {
            xPos = Random.Range(1, 3); //xPos obtiene un valor aleatorio entre ese rango
            zPos = Random.Range(1, 3); //yPos obtiene un valor aleatorio entre ese rango

            Instantiate(snow, transform.position, Quaternion.identity); // crea unnuevo objeto de tipo snow
            yield return new WaitForSeconds(0.1f); //eserpa un momento antes de crear
            snowCount += 1;
        }

    }
}
