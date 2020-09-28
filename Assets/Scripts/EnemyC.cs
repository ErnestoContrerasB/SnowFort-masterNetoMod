using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class EnemyC : MonoBehaviour
{

    public float bulletSpeed = 1;
    public Rigidbody bullet;
    private int cont = 0;
    private bool full = true;
    private bool begin = false;
    //private GameObject Ammo;
    IEnumerator FireEn()
    {
        while (cont <= 2)
        {
            //Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
            Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
            //bulletClone.position = transform.position + new Vector3(0, 1.5f, 0); 
            //Ammo = bulletClone.GetComponent<GameObject>();
            bulletClone.velocity = transform.forward * bulletSpeed;
            //Ammo.GetComponent<Rigidbody>().AddForce(transform.forwardbulletSpeed10);
            cont++;
        }
        full = false;
        begin = true;
        yield return new WaitForSeconds(3);
        Updateate();

    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(3);
        cont = 0;
        full = true;
        Updateate();
    }

    private void Updateate()
    {
        if (full == true)
            StartCoroutine(FireEn());
        else
            StartCoroutine(wait());
    }
    private void Start()
    {
        Updateate();
    }
    private void Update()
    {
        //Start();
    }
}