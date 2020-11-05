using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitch : MonoBehaviour
{
    public GameObject light;
    private bool on = false;
    public GameObject enemy;

    void OnTriggerStay(Collider player){
        if (player.tag == "Player" && !on){
            light.SetActive(true);
            on = true;
            //if (enemy!=null){
            //    enemy.GetComponent<NPC_follow>.SetActive(true);
            //}
            Debug.Log("Supposed to turn light on");
        }
        else if (player.tag == "Player" && on){
            light.SetActive(false);
            on = false;
            //if (enemy!=null){
            //    enemy.GetComponent<NPC_follow>.SetActive(false);
            //}
        }
    }
}
