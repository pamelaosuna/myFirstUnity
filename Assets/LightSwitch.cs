using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSwitch : MonoBehaviour
{
    public GameObject light;
    private bool on = false;
    public GameObject enemy;
    public Interface inter;

    void Start(){
        inter = GameObject.FindObjectOfType<Interface>();
    }
    void OnTriggerEnter (Collider player){
        if (player.tag == "Player" && !on){
            light.SetActive(true);
            on = true;
            if (enemy!=null){
                enemy.GetComponent<NPC_follow_light>().lightIsOn = true;
                inter.enemyHB.gameObject.SetActive(true);
            }
            Debug.Log("Supposed to turn light on");
        }
        else if (player.tag == "Player" && on){
            light.SetActive(false);
            on = false;
            if (enemy!=null){
                enemy.GetComponent<NPC_follow_light>().lightIsOn = false;
            }
        }
    }
}
