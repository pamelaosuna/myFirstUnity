using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour
{

public Rigidbody rb;
private bool movingRigth = false;
private bool movingLeft = false;

void FixedUpdate (){
    if (movingRigth == false && movingLeft == false){
        transform.Translate(Vector3.forward*Time.deltaTime*5);
        if (rb.transform.position.z >=6.24){
            movingRigth = true;
        }
    }
    if (movingRigth){
        transform.Translate(Vector3.forward*Time.deltaTime*5);
        if (transform.position.z >= 6.24){
             transform.Translate(Vector3.back*Time.deltaTime*5);
             movingRigth = false;
             movingLeft = true;
        }
    }
    if (movingLeft){
        transform.Translate(Vector3.back*Time.deltaTime*5);
        if (transform.position.z <= -6.4){
             transform.Translate(Vector3.forward*Time.deltaTime*5);
             movingRigth = true;
             movingLeft = false;
        }
    }
    

}

}
