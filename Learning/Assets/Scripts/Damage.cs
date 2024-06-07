using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public PlayerHealth Health;
    public float damage;

    public GameObject enemy;

    public LayerMask Hittable;

    public Transform attackPoint;

    public float attackRange;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Punch();
    }


    private void OnDrawGizmos()
    {
        if(attackPoint is null)
        {
            return;
        }

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);

    }


    void Punch()
    {

        Collider[] objs = Physics.OverlapSphere(attackPoint.position, attackRange/*, Hittable*/);

        //Debug.Log(objs);

        foreach (var obj in objs)
        {
            Debug.Log(obj);

            if (Input.GetKey(KeyCode.Mouse0) && obj.TryGetComponent(out IDamageable hit))

            {
                hit.Damage();

                Debug.Log("Delete mode");
            }       
        }

        //if (Input.GetKey(KeyCode.Mouse0))
        //{
        //    //Physics.Raycast(transform.position, Vector3.down, Playerheight * 0.5f + 0.2f, IsGround)

        //    //if player hits enemy, do damage

        //    if (Physics.Raycast(transform.position, Vector3.forward, 3f, Hittable))
        //    {
        //        Destroy(enemy);
        //    }
        //}
    }




    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
    //        Health.Health -= damage;
    //    }
    //}
}
