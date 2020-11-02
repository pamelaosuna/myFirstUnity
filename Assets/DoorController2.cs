using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController2 : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;

    // Update is called once per frame
    void Update()
    {
        if (doorIsOpening && Door.transform.position.z <1.9){
            Door.transform.Translate(Vector3.right*Time.deltaTime*2);
            Debug.Log("Door is opening!");
        }
        if (Door.transform.position.z > 1.963f){
            doorIsOpening = false;
        }
        
    }

    public void PressButton(){
        doorIsOpening = true;
    }
}
