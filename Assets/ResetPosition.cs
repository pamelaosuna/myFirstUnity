using UnityEngine;
using System.Collections;


public class ResetPosition : MonoBehaviour{
    public Transform player;
    private GameObject _player;
    public float x;
    public float y;
    public float z;


    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
    void FixedUpdate(){
        if (transform.position.y < -5){
             _player.GetComponent<PlayerHealth>().TakeDamage(10);
            transform.position = new Vector3(x, y, z);
        }
    }

}