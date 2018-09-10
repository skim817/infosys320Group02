using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour {
    public float speed = 3f;
    public GameObject myPrefab;
    // The target marker.
    public Transform target;

    // Speed in units per sec.
   

    void Update()
    {
        // The step size is equal to speed times frame time.
        float step = speed * Time.deltaTime;

        // Move our position a step closer to the target.
        transform.position = Vector3.MoveTowards(transform.position, target.position, step);
    }
    public void Move()
    {
        myPrefab.transform.Translate(Vector3.forward * Time.deltaTime);
    }

}
