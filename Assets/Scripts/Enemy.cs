using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public int speed;
    public int range;
    public GameObject player;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (player)
        {
            float distance = Vector3.Distance(player.transform.position, transform.position);
            Vector3 localPosition = player.transform.position - transform.position;
            localPosition = localPosition.normalized; // The normalized direction in LOCAL space
            if (distance < range)
            {
                transform.Translate(localPosition.x * Time.deltaTime * speed, localPosition.y * Time.deltaTime * speed, localPosition.z * Time.deltaTime * speed);
            }
        }
    }
}
