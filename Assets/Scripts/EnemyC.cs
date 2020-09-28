using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
public class EnemyC : MonoBehaviour
{

    //Es codigo que baje de otro proyecto.
    //La idea es que con un NavMesh el enemigo puede localizar a un objetivo. (Lo ideal, el usuario)
    //El original es Enemy AI

    public NavMeshAgent agent;

    public Transform player;
    public GameObject gun;

    //Stats
    public int health;

    //Check for Ground/Obstacles
    public LayerMask whatIsGround, whatIsPlayer;
    
    //Attack Player
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    //States
    public bool isDead;
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    //Special
    public Material green, red, yellow;
    public GameObject projectile;

    private void Awake()
    {
        player = GameObject.Find("Cube").transform;
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        if (!isDead)
        {
            //Check if Player in sightrange
            playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);

            //Check if Player in attackrange
            playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

            
            if (playerInAttackRange && playerInSightRange) AttackPlayer();
        }
    }

    
    private void AttackPlayer()
    {
        if (isDead) return;

        //Make sure enemy doesn't move
        agent.SetDestination(transform.position);

        transform.LookAt(player);

        if (!alreadyAttacked)
        {

            //Attack
            Rigidbody rb = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<Rigidbody>();

            //Aqui en AddForce se crea la velocidad con la que ataca el proyectil del enemigo

            //rb.AddForce(transform.forward * 32f, ForceMode.Impulse);
            //rb.AddForce(transform.up * 8, ForceMode.Impulse);

            rb.AddForce(transform.forward , ForceMode.Impulse);
            rb.AddForce(transform.up , ForceMode.Impulse);

            alreadyAttacked = true;
            Invoke("ResetAttack", timeBetweenAttacks);
        }

        GetComponent<MeshRenderer>().material = red;
    }
    private void ResetAttack()
    {
        if (isDead) return;

        alreadyAttacked = false;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 0)
        {
            isDead = true;
            Invoke("Destroyy", 2.8f);
        }
    }
    private void Destroyy()
    {
        Destroy(gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, sightRange);
    }
}
