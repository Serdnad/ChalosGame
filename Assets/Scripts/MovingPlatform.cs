using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{

    float min;
    float max;
    public float xdistance = 0;

    // Use this for initialization
    void Start()
    {
        min = transform.position.x;
        max = min + Mathf.Abs(xdistance);
    }

    // Update is called once per frame
    void Update()
    {
        if (xdistance > 0)
        {
            transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);
        }
        if (xdistance < 0)
        {
            transform.position = new Vector3(-Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z);
        }
    }
}