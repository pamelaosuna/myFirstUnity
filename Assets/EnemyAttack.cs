using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour{
    private Animator _animator;
    private GameObject _player;
    private bool _collidedWithPlayer;
    public bool isInvincible = false;
    //private bool collidedWithObstacle;

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _animator = GetComponent<Animator>();
    }

    void OnCollisionEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "Enemy" && !isInvincible){
            _player.GetComponent<PlayerHealth>().TakeDamage(10);
            // receive damage

            //Debug.Log("Collision with enemy!");

        }
    }

    
}