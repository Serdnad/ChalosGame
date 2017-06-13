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

    IEnumerator deathTimer()
    {
        Destroy(GetComponent<Rigidbody>());
        Destroy(GetComponent<MeshFilter>());
        Destroy(GetComponent<BoxCollider>());
        Destroy(GetComponent<PlayerMovement>());
        Vector3 updatedposition = transform.position;
        Instantiate(playerdeath, updatedposition, transform.rotation);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
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
            StartCoroutine(deathTimer());
        }
    }
}
