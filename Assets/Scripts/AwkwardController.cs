using System.Collections;
using System.Collections.Generic;
using Image = UnityEngine.UI.Image;
using UnityEngine;

public class AwkwardController : MonoBehaviour {
    Image AwkwardBar;
    float tmpHealth; 
	// Use this for initialization
	void Start () {
        //   AwkwardBar = GameObject.Find("HealthCamera").transform.FindChild("AwkCanvas").FindChild("AwkwardBar").GetComponent<Image>(); 	
        AwkwardBar = GetComponent<Image>();
    }

    public void changeAwkwardHealth()
    {
        tmpHealth = Random.Range(0f, 1f);
        AwkwardBar.fillAmount = tmpHealth;
    }
}
