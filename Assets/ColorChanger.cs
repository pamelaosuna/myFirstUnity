 using UnityEngine;
 using System.Collections;
 
 public class ColorChanger : MonoBehaviour {
    private bool potionTaken;
         //Get Initial Color
     public Material[] materials;
    public Renderer Rend; 
    private GameObject _player;
    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");

    }
    void Start(){
        Rend = GetComponent<Renderer>();
        Rend.enabled = true;
    }

    void OnTriggerEnter(Collider col){
        if(col.tag == "Potion"){
            if (materials.Length == 0)
                return;
            StartCoroutine(ChangeColor());
        }
    }

    void OnCollisionEnter(Collision collisionInfo){
        //Debug.Log("collision detected in color changer");
        if (collisionInfo.collider.tag == "MagicPotion"){
            Destroy(collisionInfo.collider.gameObject);
            if (materials.Length == 0)
                return;
            StartCoroutine(ColorInvincible());
        }
    }

    IEnumerator ChangeColor(){
        Material mat = Rend.sharedMaterial;
        Rend.sharedMaterial = materials[1];
        yield return new WaitForSeconds(2);
        Rend.sharedMaterial = materials[0];
    }
    
    IEnumerator ColorInvincible(){
        //Debug.Log("Change coloooor bc invincible!");
        Material mat = Rend.sharedMaterial;
        Rend.sharedMaterial = materials[2];
        yield return new WaitForSeconds(10);
        Rend.sharedMaterial = materials[0];
    }
 }