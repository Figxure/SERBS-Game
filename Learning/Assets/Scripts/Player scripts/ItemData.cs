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

    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "PlayerCapsule")
        {
            Item.transform.parent = playerPos.transform;

            Item.transform.position = playerPos.transform.position;



            rb.constraints = RigidbodyConstraints.FreezePositionZ;
            //rb.useGravity = false;
        }
    }


}