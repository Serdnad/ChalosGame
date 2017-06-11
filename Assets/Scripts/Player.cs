using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {
    // Use this for initialization
    void Start () {
    }
	
	// It is recommended to use FixedUpdate for calculating forces/movement
	void FixedUpdate () {
        if (Input.GetKey("up")|| Input.GetKey("w"))
            this.GetComponent<Rigidbody>().AddForce(transform.forward * 20);
        if (Input.GetKey("down")|| Input.GetKey("s"))
            this.GetComponent<Rigidbody>().AddForce(-transform.forward * 20);
        if (Input.GetKey("left")|| Input.GetKey("a"))
            this.GetComponent<Rigidbody>().AddForce(-transform.right * 20);
        if (Input.GetKey("right")|| Input.GetKey("d"))
            this.GetComponent<Rigidbody>().AddForce(transform.right * 20);


        if (gameObject.transform.position.y<-8)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index+1,LoadSceneMode.Single);
        }
    }

}
