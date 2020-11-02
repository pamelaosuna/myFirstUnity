using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    
    void Update()
    {
        transform.position = player.position + offset;

        offset.x += Input.GetAxis("Mouse ScrollWheel");
        offset.y += Input.GetAxis("Mouse ScrollWheel");
    }
}
