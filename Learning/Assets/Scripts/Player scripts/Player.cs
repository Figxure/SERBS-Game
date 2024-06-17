using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public Healthbar healthBar;

    public bool hit = true;

    public bool hasItem = false;

    public Transform handPos;

    public Transform Orientation;

    [SerializeField] private GameObject playerItem;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G) && playerItem != null)
        {
            drop(playerItem);
        }
    }

    public void TakeDamage(int damage)
    {

        if (hit)
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


    private void OnCollisionEnter(Collision collision)
    {
        var item = collision.gameObject.GetComponent<ItemData>();

        if (!item || hasItem)
        {
            return;
        }

        hasItem = true;

        item.gameObject.transform.parent = handPos.transform;

        item.gameObject.transform.position = handPos.position;

        item.gameObject.transform.rotation = Orientation.rotation; 

        item.gameObject.transform.Rotate(0, 90, 0);

        item.rb.isKinematic = true;

        playerItem = item.gameObject;

        Debug.Log("I have an item");
    }

    void drop(GameObject Item)
    {
        hasItem = false;

        playerItem = null;

        Rigidbody rb = Item.GetComponent<Rigidbody>();

        rb.isKinematic = false;

        rb.detectCollisions = true;


        Item.transform.parent = null;

        Debug.Log("Dropped item");
    }

}