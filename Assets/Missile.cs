
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour{
    public Transform target;
    public float speed = 200f;
    public float accelerationRate = 20f;
    public float rotationForce = 30f;
    private Vector3 angularVelocity;
    public Rigidbody rgdbody;

    private void FixedUpdate(){
        var nextDirection = (target.position - transform.position).normalized;
        var targetVelocity = nextDirection * speed;
        var deltaVelocity = targetVelocity - rgdbody.velocity;
        var force = deltaVelocity * accelerationRate;
        var turnDirection = nextDirection;

        if (turnDirection == Vector3.zero){
            angularVelocity = Vector3.zero;
        }
        else{
            var rotationAngleY = Vector3.Cross(transform.forward, nextDirection);
            angularVelocity = (rotationAngleY * rotationForce * Time.deltaTime);
        }
        rgdbody.AddForce(force, ForceMode.Acceleration);
        rgdbody.angularVelocity = angularVelocity;
        }

    }