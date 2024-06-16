using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyAI : EnemyStructure, IDamageable
{
    public Player player;
    Rigidbody rb;

    [Header("Ground Check")]
    public float Playerheight;

    NavMeshAgent agent;

    public Transform playerTransform;

    //Vector3 destination;

    public GameObject Enemy;

    public LayerMask IsGround;

    public float groundDrag;

    bool grounded;

    public float timeBetweenAttacks;

    public bool readyToAttack = true;

    public bool attacked;


    //public int Health { get; set; }


    public void Damage()
    {
        //takes away 50 health
            currentHealth -= 50;

        //checks if he's dead, then deletes him
            if (currentHealth <= 0)
            {
                Destroy(Enemy);
            }
    }

    // Start is called before the first frame update
    public void Start()
    {


        agent = this.GetComponent<NavMeshAgent>();

        rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;
    }

    // Update is called once per frame
    protected override void Update()
    {

        //checks if on ground
        grounded = Physics.Raycast(transform.position, Vector3.down, Playerheight * 0.5f + 0.2f, IsGround);

        if (grounded)
        {
            rb.drag = groundDrag;
            rb.angularDrag = groundDrag;
        }


        Chase();
        
    }

    public void Chase()
    {
        agent.SetDestination(playerTransform.transform.position);

        Vector3 Distance = playerTransform.transform.position - agent.transform.position;

        if (Distance.magnitude <= 2.2f)
        {
            //stops the agent
            agent.isStopped = true;

            //checks if its ready to attack, then invokes attack method after 0.5 seconds
            if (readyToAttack == true)
            {
                Invoke("Attack", 0.8f);
            }


        }
        else
        {
            agent.isStopped = false;
        }
    }



    protected override void Attack()
    {
        //calls player take damage function
        base.Attack();
        player.TakeDamage(10);

        //sets ready to attack to false
        readyToAttack = false;

        //Debug.Log("Goon attacked");

        //if(readyToAttack == false)
        Invoke("ResetAttack", 1.0f);

    }

    void ResetAttack()
    {
        //attacked = false;
        readyToAttack = true;

        Invoke("Chase", 0.5f);
    }
}
