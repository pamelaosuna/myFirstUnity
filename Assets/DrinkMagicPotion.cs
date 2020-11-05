 using UnityEngine;
 using System.Collections;
 
 public class DrinkMagicPotion : MonoBehaviour {
    private GameObject _player;
    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");

    }

    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "MagicPotion"){
            Debug.Log("Collided with magic potion!");
            //_player.GetComponent<ColorChanger>().enabled = true;
            StartCoroutine(TurnInvincible());
        }
    }

    IEnumerator TurnInvincible(){
         GetComponent<EnemyAttack>().isInvincible = true;
         yield return new WaitForSeconds(10);//2 seconds for exxample
         GetComponent<EnemyAttack>().isInvincible = false;
    }


 }