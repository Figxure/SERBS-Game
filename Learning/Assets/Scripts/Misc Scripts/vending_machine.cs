using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vending_machine : MonoBehaviour
{
    public GameObject HealthDrink;

    public Player player;

    public Transform spawnPoint;

    private void OnTriggerStay(Collider other)
    {

        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(HealthDrink);

            HealthDrink.transform.position = spawnPoint.position;


            if (player.currentHealth < player.maxHealth)
            {
                player.currentHealth = player.currentHealth + 10;
                player.healthBar.SetHealth(player.currentHealth);
            }


            Invoke("DeleteCans", 5f);

        }
    }

    void DeleteCans()
    {
        Destroy(HealthDrink);
    }
}
