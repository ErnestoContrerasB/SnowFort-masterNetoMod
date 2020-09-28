using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //La idea original es usar un Object Pool pero se solucino con un paso extra en el script Enemy



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
        while (enemyCount < 1) //aqui manejas la cantidad de enemigos que quieres
        {
            GameObject en1 = Instantiate(enemyPrefab, new Vector3(0, 0, 5), Quaternion.Euler(new Vector3(0, 180, 0)));
            en1.SetActive(true);                                                                             //

            yield return new WaitForSeconds(0.1f);
            enemyCount += 1;
        }

    }
}

