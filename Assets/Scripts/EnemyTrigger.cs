﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour {
    public GameObject enemy;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = enemy.transform.position;
    }
}
