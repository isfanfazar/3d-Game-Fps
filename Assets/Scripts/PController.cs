﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PController : MonoBehaviour {

	public float speed;
	public GameObject ball;
	public GameObject titikLontar;
	public float powerLontar;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(0, 0, Input.GetAxis("Vertical")*speed*Time.deltaTime);
		transform.Rotate(0, Input.GetAxis("Horizontal")*60*Time.deltaTime, 0);
		
	//space for lontar
		if (Input.GetKeyDown(KeyCode.Space)){
			GameObject _ball = GameObject.Instantiate (ball, titikLontar.transform.position, titikLontar.transform.rotation);
			 _ball.GetComponent<Rigidbody> ().AddForce (_ball.transform.forward * powerLontar);
			GameObject.Destroy (_ball, 5);
		}
	}
}
