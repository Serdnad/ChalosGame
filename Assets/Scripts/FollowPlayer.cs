﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject player;       //Public variable to store a reference to the player game object


    private Vector3 offset = new Vector3(0, 10, -10); //Private variable to store the offset distance between the player and camera

    // Use this for initialization
    void Start()
    {
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        //offset = transform.position - player.transform.position;
    }

    // FixedUpdate is called through evenly spaced time intervals, regardless of framerate.
    void FixedUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        //Vector3.Lerp moves the object to the target incrementally. The resulting effect gives a sense of movement.
        transform.position = Vector3.Lerp(this.transform.position, player.transform.position + offset, 0.1f);
    }
}
