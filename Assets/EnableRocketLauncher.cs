using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableRocketLauncher : MonoBehaviour{

    public RocketLauncher myRocket;

    public GameObject rocket;
    private GameObject _player;

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    void Start(){
        myRocket = rocket.GetComponent<RocketLauncher>();
    }
    void OnTriggerEnter(Collider col){
        if (col.tag == "weapon"){
            print("On trigger with weapon!");
            myRocket.enabled = true;
            //col.GetComponent(RocketLauncher).enabled = !col.GetComponent(RocketLauncher).enabled;
        }    
    }

}