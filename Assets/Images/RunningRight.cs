using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunningRight : MonoBehaviour {
    public float movementSpeed = -0.05f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = this.transform.position;
        //transform.position += Vector3.forward * Time.deltaTime * movementSpeed;
        //position.x--; 
        position.x -= 0.05f; 
        this.transform.position = position; 
        //transform.position += transform.forward * Time.deltaTime * movementSpeed;
    }
}
