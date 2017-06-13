using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject player;
    private Vector3 cameraOffset = new Vector3(0, 10, -10);

    // Use this for initialization
    void Start()
    {

    }
    
    void FixedUpdate()
    {
        //if player exists, follow it
        if(player)
            transform.position = Vector3.Lerp(this.transform.position, player.transform.position + cameraOffset, 0.1f);
    }
}
