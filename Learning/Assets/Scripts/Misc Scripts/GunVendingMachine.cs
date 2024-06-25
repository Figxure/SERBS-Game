using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunVendingMachine : MonoBehaviour
{
    public GameObject Gun;

    public Transform Orientation;

    public Player player;

    public Transform spawnPoint;

    public float DespawnTime = 10f;


    private void Update()
    {
        //if (DespawnTime > 0)
        //{
        //    DespawnTime -= Time.deltaTime;
        //    if (DespawnTime <= 0)
        //    {
        //        DeleteGuns();
        //    }
        //}
    }

    private void OnTriggerStay(Collider other)
    {



        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(Gun);

            Gun.transform.position = spawnPoint.position;

            Gun.transform.parent = Orientation.transform;



            //Invoke("DeleteCans", 5f);

        }
    }

    void DeleteGuns()
    {
        //Destroy(this.gameObject);
    }
}
