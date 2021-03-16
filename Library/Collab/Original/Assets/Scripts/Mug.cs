using System;
using System.Collections;
using UnityEngine;

public class Mug : MonoBehaviour {
    public Vector3 Destination = new Vector3(0, 0, 0);
    
    public GameObject[] Liquids;

    public void Start() {
        while (transform.position.x > 0) {
            transform.position = Vector3.Lerp(transform.position, Destination, Time.deltaTime);
        }
        
    }
}