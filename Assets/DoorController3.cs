using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController3 : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;

    // Update is called once per frame
    void Update()
    {
        if (doorIsOpening){
            Door.transform.Translate(Vector3.up*Time.deltaTime*1);
        }
        if (Door.transform.position.y > 6.5f){
            doorIsOpening = false;
        }
        
    }

    public void PressButton(){
        doorIsOpening = true;
    }
}