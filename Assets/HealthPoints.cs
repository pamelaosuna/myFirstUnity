using UnityEngine;
using System.Collections;


public class HealthPoints : MonoBehaviour{
    private Animator _animator;
    private GameObject _player;
    private bool _collidedWithPlayer;

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Potion"){
            //print("On trigger enter (HealthPoints)");
            Destroy(col.gameObject);
            _player.GetComponent<PlayerHealth>().Recover(10);
            // receive damage
            Destroy(col.gameObject);

            print("You are recovering!");
      }
    }

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Potion"){
            //collidedWithObstacle = true;
            _player.GetComponent<PlayerHealth>().Recover(10);
            _player.GetComponent<ColorChanger>().enabled = true;
            // receive damage
            Destroy(collisionInfo.collider);

            print("You are recovering!");

        }
       
    }

    
}