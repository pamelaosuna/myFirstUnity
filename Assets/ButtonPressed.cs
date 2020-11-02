using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed : MonoBehaviour
{
    public DoorController doorCont;
    public GameObject button;


    void OnCollisionEnter(Collision collisionInfo){
        if (collisionInfo.collider.tag == "Player"){
            doorCont.PressButton();
        }
        //button.transform.localScale.y(Vector3.down*Time.deltaTime*0.015f);
        //button.transform.localScale.y(Vector3.up*Time.deltaTime*0.015f);
        
    }
}
