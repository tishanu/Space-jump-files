using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{ 
    public float jump = 5;
    public float sidewayTransition = 5;
    public float speed=1;
    private Rigidbody rb;
    private bool onGround = true;
    float hMov, vMov;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        if (Input.GetKeyDown("space") && onGround)
        {
            rb.AddForce(Vector3.up * jump, ForceMode.Impulse);
            onGround = false;
        }
    }
    void FixedUpdate()
    { 
        hMov = Input.GetAxis("Horizontal");
        vMov = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(0,0,sidewayTransition * Time.deltaTime,ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(0,0,-sidewayTransition*Time.deltaTime, ForceMode.VelocityChange);
        }
        //rb.velocity=transform.right *speed*Time.deltaTime;
        rb.AddForce(speed * Time.deltaTime, 0, 0 );
    }

    void OnCollisionEnter(Collision collision)
    {
        onGround = true;
    }
}
