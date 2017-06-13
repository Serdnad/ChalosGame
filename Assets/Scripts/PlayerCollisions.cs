using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollisions : MonoBehaviour {

    public GameObject playerdeath;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            int index = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(index + 1, LoadSceneMode.Single);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Instantiate(playerdeath, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
