using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sidewaysForce = 500f;
    // Start is called before the first frame update
    void FixedUpdate (){
        rb.AddForce(0, 0, forwardForce*Time.deltaTime);
        
        if (Input.GetKey("d")){
            rb.AddForce(0, 0, sidewaysForce*Time.deltaTime);
        }

        if (Input.GetKey("a")){
            rb.AddForce(0, 0, -sidewaysForce*Time.deltaTime);
        }

        if (Input.GetKey("w")){
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s")){
            rb.AddForce(sidewaysForce*Time.deltaTime, 0, 0);
        }
        
        if (Input.GetKey("space")){
            rb.AddForce(0, sidewaysForce*Time.deltaTime, 0);
        }

    }
}
