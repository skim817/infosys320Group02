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
     
    }
    public void Move()
    {
       
            transform.Translate(Vector3.forward);
        
    }

}
