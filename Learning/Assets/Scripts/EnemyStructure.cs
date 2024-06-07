using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class  EnemyStructure : MonoBehaviour
{
    public float Health;

    //public float speed;



    protected abstract void Update();

  
    protected virtual void Attack()
    {
        Debug.Log("Enemy Class: Attack Method Called");
    }

}
