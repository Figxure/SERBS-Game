using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EnemyAI : EnemyStructure, IDamageable
{
    Rigidbody rb;

    [Header("Ground Check")]
    public float Playerheight;

    NavMeshAgent agent;

    public Transform player;

    Vector3 destination;

    public GameObject Enemy;

    //public PlayerHealth playerVitals;

    public LayerMask IsGround;

    public float groundDrag;

    bool grounded;

    public int Health { get; set; }


    public void Damage()
    {
        Health = Health - 50;

        Destroy(Enemy);

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
        agent.SetDestination(player.transform.position);

        Vector3 Distance = player.transform.position - agent.transform.position;

        if (Distance.magnitude < 2f)
        {
            agent.isStopped = true;
            //playerVitals.Health -= 10f;
        }
        else
        {
            agent.isStopped = false;
        }


    }

    protected override void Attack()
    {

        base.Attack();

        Debug.Log("Goon attacked");

    }





    //private void FaceTarget()
    //{

    //    Vector3 lookPos = destination - transform.position;
    //    lookPos.y = 0;
    //    Quaternion rotation = Quaternion.LookRotation(lookPos);
    //    transform.rotation = Quaternion.Slerp(transform.rotation, rotation, 3f);
    //}
}
