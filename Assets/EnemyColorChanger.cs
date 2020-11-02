 using UnityEngine;
 using System.Collections;
 
 public class EnemyColorChanger : MonoBehaviour {
     public Material[] materials;
    public Renderer Rend; 
    private GameObject enemy;

     void Awake()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");

    }

    void Start(){
        Rend = GetComponent<Renderer>();
        Rend.enabled = true;
    }

    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Burning"){
            Debug.Log("Changing enemy color!");
            if (materials.Length == 0){
                Debug.Log("no materiales listed");
                return;
            }
            StartCoroutine(ChangeColor());
        }
    }

    IEnumerator ChangeColor(){
        Material mat = Rend.sharedMaterial;
        Rend.sharedMaterial = materials[1];
        yield return new WaitForSeconds(2);//2 seconds for exxample
        Rend.sharedMaterial = materials[0];
    }
 
 }