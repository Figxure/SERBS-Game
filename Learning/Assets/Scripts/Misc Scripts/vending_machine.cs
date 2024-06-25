using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vending_machine : MonoBehaviour
{
    public GameObject HealthDrink;

    public Transform Orientation;

    public Player player;

    public Transform spawnPoint;

    public float DespawnTime = 10f;


    private void Update()
    {
        //if(DespawnTime > 0)
        //{
        //    DespawnTime -= Time.deltaTime;
        //    if(DespawnTime <= 0)
        //    {
        //        DeleteCans();
        //    }
        //}
    }


    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(HealthDrink);

            HealthDrink.transform.position = spawnPoint.position;

            HealthDrink.transform.parent = Orientation.transform;

            if (player.currentHealth < player.maxHealth)
            {
                player.currentHealth = player.currentHealth + 10;
                player.healthBar.SetHealth(player.currentHealth);
            }


            //Invoke("DeleteCans", 5f);

        }
    }

    void DeleteCans()
    {
       // Destroy(this.gameObject);
    }
}
