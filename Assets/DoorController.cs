using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;

    // Update is called once per frame
    void Update()
    {
        if (doorIsOpening){
            Door.transform.Translate(Vector3.up*Time.deltaTime*5);
        }
        if (Door.transform.position.y > 2f){
            doorIsOpening = false;
        }
        
    }

    public void PressButton(){
        doorIsOpening = true;
    }
}
