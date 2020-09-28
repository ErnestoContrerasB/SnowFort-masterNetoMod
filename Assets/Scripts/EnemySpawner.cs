using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //La idea original es usar un Object Pool pero se solucino con un paso extra en el script Enemy

    
    //ObjectPooler objectPooler;
    private int xPos;
    private int zPos;
    public GameObject enemyPrefab;
    public int enemyCount;

    
    private void Start()
    {
        //objectPooler = ObjectPooler.Instance;
        StartCoroutine(EnemyDrop());
    }


    //private void FixedUpdate()
    IEnumerator EnemyDrop()
    {
        while (enemyCount < 5) //aqui manejas la cantidad de enemigos que quieres
        {
            enemyPrefab.SetActive(true); //esto es solo para forzar que siempre se vean los enemigos
            xPos = Random.Range(-3, 3); //xPos obtiene un valor en el rango
            zPos = Random.Range(-3, 3); //yPos obtiene un valor en el rango
            //objectPooler.SpawnFromPool("Snowman", transform.position, Quaternion.identity);  
            //objectPooler.SpawnFromPool("Snowman", new Vector3(xPos, 0, zPos), Quaternion.identity);
            
            Instantiate(enemyPrefab, new Vector3(xPos, 0, zPos+5), Quaternion.identity); //Le dices que cree en el momento un objeto tipo enemyPrefab, en las posiciones aleatorias
                                                                                         //
            
            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }

    }
}
