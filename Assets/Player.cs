using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up")|| Input.GetKey("w"))
            this.GetComponent<Rigidbody>().AddForce(transform.forward * 20);
        if (Input.GetKey("down")|| Input.GetKey("s"))
            this.GetComponent<Rigidbody>().AddForce(-transform.forward * 20);
        if (Input.GetKey("left")|| Input.GetKey("a"))
            this.GetComponent<Rigidbody>().AddForce(-transform.right * 20);
        if (Input.GetKey("right")|| Input.GetKey("d"))
            this.GetComponent<Rigidbody>().AddForce(transform.right * 20);

    }
}
