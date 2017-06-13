using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetOnDeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
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
