using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class Player : MonoBehaviour
    {
        public int maxHealth = 100;
        public int currentHealth;
        public Healthbar healthBar;

        public bool hit = true;

        // Start is called before the first frame update
        void Start()
        {
            currentHealth = maxHealth;
            healthBar.SetMaxHealth(maxHealth);

        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void TakeDamage(int damage)
        {

            if(hit)
            {
                currentHealth -= damage;

                healthBar.SetHealth(currentHealth);

                hit = false;
            }



        Invoke("ResetHit", 1f);

        }

        void ResetHit()
        {
            hit = true;
        }
    }