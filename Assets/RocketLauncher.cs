using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{

    public Transform targetEnemy;
    public float force;
    public float rotationForce;
    public float launchForce;
    private bool shouldFollow;
    private Rigidbody rb;
    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(WaitBeforeHoming());
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (shouldFollow){
            if (targetEnemy!= null){
                // replace targetEnemy.position by mouseClick position, so we click to launch the missile
                Vector3 direction = targetEnemy.position - rb.position;
                direction.Normalize();
                Vector3 rotationAmount = Vector3.Cross(transform.forward, direction);
                rb.angularVelocity = rotationAmount * rotationForce;
                rb.velocity = transform.forward * force;
            }
        }
    }

    private void OnCollisionEnter(Collision collision){
        //if (collision.collider.tag == "Player"){
        //    targetEnemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        //}
        if (collision.collider.tag == "Enemy"){
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
        }
    }
    private IEnumerator WaitBeforeHoming(){
        rb.AddForce(Vector3.up*launchForce, ForceMode.Impulse);
        yield return new WaitForSeconds(2);
        shouldFollow = true;
    }
}
