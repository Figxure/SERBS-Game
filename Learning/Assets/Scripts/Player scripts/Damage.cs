using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public Healthbar Health;
    public float damage;
    public LayerMask Hittable;
    public Transform attackPoint;
    public float attackRange;

    public bool allowPunch = true;


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
            //Debug.Log(obj);

            if (Input.GetKey(KeyCode.Mouse0) && obj.TryGetComponent(out IDamageable hit) && allowPunch == true)
            {
                hit.Damage();

                //Debug.Log("hit mode");

                allowPunch = false;

                Invoke("ResetPunch", 0.3f);
            }       
        }
    }

    private void ResetPunch()
    {
        allowPunch = true;
    }
}


