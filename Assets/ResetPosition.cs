using UnityEngine;
using System.Collections;


public class ResetPosition : MonoBehaviour{
    public Transform player;
    private GameObject _player;


    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    void FixedUpdate(){
        if (transform.position.y < -5){
             _player.GetComponent<PlayerHealth>().TakeDamage(10);
            transform.position = new Vector3(625.0f, 0.0f, 555.0f);
        }
    }

}