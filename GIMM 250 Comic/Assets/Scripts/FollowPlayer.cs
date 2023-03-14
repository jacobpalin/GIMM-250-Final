using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(1, 1, -1);

    void Start()
    {

    }

    void LateUpdate()
    {
        //offet the camera behind the player to follow the player
        transform.position = player.transform.position + offset;
    }
}
