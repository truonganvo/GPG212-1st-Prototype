using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //movement and looking direction
    public float movementSpeed;
    public Transform orientation;

    float horizontalInput;
    float VerticalInput;

    Vector3 moveDirection;

    Rigidbody rb;

    //Ground Check -- So the player doesn't slide/accelerate non stop
    public float groundDrag;
    public float playerHeight;
    public LayerMask whoIsThePlayer;
    bool grounded;

    //SFX
    [SerializeField] AudioSource footstep;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true; //player won't fall down: is like tripping...
    }

    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void Update()
    {
        MyInput();
        SpeedControl();

        //ground check, then add gravity drag
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, whoIsThePlayer);
        if (grounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = 0;
        }
    }

    private void MyInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        VerticalInput = Input.GetAxisRaw("Vertical");
    }

    private void MovePlayer()
    {
        //calculate the movement direction
        moveDirection = orientation.forward * VerticalInput + orientation.right * horizontalInput;
        //then add force
        rb.AddForce(moveDirection.normalized * movementSpeed * 10f, ForceMode.Force);
    }

    private void SpeedControl()
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);

        //limit the velocity if needed
        if (flatVel.magnitude > movementSpeed) //if go faster than the initial speed 
        {
            Vector3 limitedVel = flatVel.normalized * movementSpeed; //calculate what the max speed would be 
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z); //then set it && apply it.
        }
    }
}
