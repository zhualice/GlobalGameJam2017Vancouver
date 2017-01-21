using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveButton : MonoBehaviour {

    public GameObject red; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void wave()
    {
        red = GameObject.Find("Red");
        red.transform.Translate(Vector3.up); 
        
    }
}
