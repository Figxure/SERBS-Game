using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItemData : MonoBehaviour
{

    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }




}