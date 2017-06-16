using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnDeath : MonoBehaviour {
    public GameObject playerdeath;
	// Use this for initialization
	void Start () {

        GetComponent<Rigidbody>().AddExplosionForce(20, playerdeath.transform.position, 2, 0);
        Invoke("ResetLevel", 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
    }

    // Resets the level
    void ResetLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
