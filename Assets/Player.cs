using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey("up"))
            this.GetComponent<Rigidbody>().AddForce(transform.forward * 15);
        else if (Input.GetKey("down"))
            this.GetComponent<Rigidbody>().AddForce(-transform.forward * 15);
        else if (Input.GetKey("left"))
            this.GetComponent<Rigidbody>().AddForce(-transform.right * 15);
        else if (Input.GetKey("right"))
            this.GetComponent<Rigidbody>().AddForce(transform.right * 15);
    }
}
