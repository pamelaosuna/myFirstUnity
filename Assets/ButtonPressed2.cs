using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPressed2 : MonoBehaviour
{
    public DoorController2 doorCont;
    public GameObject button;


    void OnCollisionEnter(Collision collisionInfo){
        if (collisionInfo.collider.tag == "Player"){
            doorCont.PressButton();
            Debug.Log("Pressing button");
        }
        //button.transform.localScale.y(Vector3.down*Time.deltaTime*0.015f);
        //button.transform.localScale.y(Vector3.up*Time.deltaTime*0.015f);
        
    }
}
