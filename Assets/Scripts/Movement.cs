using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{

    //"



    public float speed;

    private Rigidbody rb;

    public float jump;

    internal bool isGrounded; //hay que poner el trigger y toda esa mrd. ;(

    internal int doubleJump = 1;

    internal int maxDoubleJump;





    //"


    void Start()
    {





        rb = GetComponent<Rigidbody>();

        maxDoubleJump = doubleJump;

    }

    void Update()
    {

        //transform.position = new Vector3(transform.position.x+speed*Time.deltaTime, transform.position.y, transform.position.z);                                                                                                                                                                                                                                                                                                                                                                                                      


        if (isGrounded)
        {
            doubleJump = 1;
        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector3(1, 0, 0) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector3(1, 0, 0) * speed * -Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(new Vector3(0, 0, 1) * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(new Vector3(0, 0, 1) * speed * -Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A))
        {
            rb.velocity = new Vector3(rb.velocity.x * 0.3f, rb.velocity.y, rb.velocity.z);
        }
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            rb.velocity = new Vector3(rb.velocity.x, rb.velocity.y, rb.velocity.z * 0.3f);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.AddForce(new Vector3(0, 1, 0) * jump);
        }
                                                                                                //he areglado los if de is grounded pulinedolos, tu ya sabes.
        if (Input.GetKeyDown(KeyCode.Space) && doubleJump == 1 && isGrounded == false)
        {
            rb.AddForce(new Vector3(0, 1, 0) * jump);
            doubleJump--;
        }
    }
}
