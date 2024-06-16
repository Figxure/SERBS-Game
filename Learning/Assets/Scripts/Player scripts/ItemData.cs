using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//public enum SlotTag { None, slotOne, slotTwo, slotThree, slotFOur, slotFive }

//[CreateAssetMenu(menuName = "Item Data")]
public class ItemData : MonoBehaviour
{
    //public string id;

    //public string displayName;
    // public SlotTag itemtag;

    // public Sprite icon;


    public GameObject Item;

    public GameObject playerPos;

    public Transform ItemObj;

    public Transform ItemNewPos;

    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    private void FixedUpdate()
    {
        //OnCollisionEnter(Collision collision) ;

        drop();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerCapsule")
        {
            Item.transform.parent = playerPos.transform;

            //Item.transform.position = playerPos.transform.position;

            ItemObj.position = ItemNewPos.position;

            rb.isKinematic = true;

            //Item.GetComponent<Rigidbody>().enabled = false;

            //Destroy(rb);

        }


    }

    void drop()
    {
        if (Input.GetKey(KeyCode.G))
        {
            Debug.Log("Pressed G");

            
            Rigidbody rb = Item.GetComponent<Rigidbody>();

            rb.isKinematic = false;

            //rb = GetComponent<Rigidbody>();

            Item.transform.parent = null;

            //Item.transform.parent(null);
        }
    }


}