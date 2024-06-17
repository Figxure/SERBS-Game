using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vending_machine : MonoBehaviour
{
    public GameObject HealthDrink;

    public Player player;

    private void OnTriggerStay(Collider other)
    {
        while(true)
        {
            if(Input.GetKey(KeyCode.F))
            {
                Instantiate(HealthDrink);

                if(player.currentHealth < player.maxHealth)
                {
                    player.currentHealth += 10;
                }
                    
            }
        }
    }
}
