using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //Movement  v
    Rigidbody rb;

    public Transform orientation;

    [SerializeField] const float ConstSpeed = 7f;

    [SerializeField] float Move_Speed;

    [SerializeField] float Sprint_Speed;

    Vector3 moveDir;
    //Movement  ^

    //Friction v
    [Header("Keybinds")]
    public KeyCode jumpkey = KeyCode.Space;


    [Header("Ground Check")]
    public float Playerheight;

    public LayerMask IsGround;

    public float groundDrag;

    bool grounded;
    //Friction ans jump ^
    
    //Jump v
    public float jumpforce;

    public float jumpCoolDown;

    public float airmultiplier;

    bool ReadyToJump = true;

    //jump ^



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.freezeRotation = true;
    }

    // Update is called once per frame
    void Update()
    {
        //checks if on ground
        grounded = Physics.Raycast(transform.position, Vector3.down, Playerheight * 0.5f + 0.2f, IsGround);

        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0;
            rb.angularDrag = 100f;
        }


        if (Input.GetKeyDown(jumpkey) && ReadyToJump && grounded)
        {
            ReadyToJump = false;

            Jump();

            Invoke(nameof(ResetJump), jumpCoolDown);

            Debug.Log("Jump");
        }

        Move();
    }

    void Move()
    {
        //simple code that adds in running
        if (Input.GetKey(KeyCode.LeftShift) == true)
        {
            rb.AddForce(moveDir.normalized * 13f, ForceMode.Force);
        }
        else if (Input.GetKey(KeyCode.LeftShift) == false)
        {
            Move_Speed = 18f;
        }


        //gets vertical and horizontal input mapping
        float XAxis = Input.GetAxisRaw("Horizontal");
        float YAxis = Input.GetAxisRaw("Vertical");


        //makes them frame dependant and gives them a set speed
        float Xdir = XAxis*Move_Speed*Time.deltaTime;
        float Ydir = YAxis*Move_Speed*Time.deltaTime;



        //vector that determines where player is gonna move based on orientation. we multiply the inputs to give it a direction and input
        moveDir = orientation.forward * Ydir + orientation.right * Xdir;




        //adds force to the theoretical direction and moves us, god i love physics
        if (grounded)        
            rb.AddForce(moveDir.normalized * 10f, ForceMode.Force);


        else if(!grounded)
            rb.AddForce(moveDir.normalized * 10f * airmultiplier, ForceMode.Force);

    }

    void Jump()
    {

        

        //reset y velocity
        rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //jump
        rb.AddForce(transform.up * jumpforce, ForceMode.Impulse);
    }

    void ResetJump()
    {
        ReadyToJump = true;
    }
}
