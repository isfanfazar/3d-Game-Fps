﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawn : MonoBehaviour {

	public GameObject monster;
	// Use this for initialization
	void Start () {
		StartCoroutine (StartSpawning());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	IEnumerator StartSpawning() {
		yield return new WaitForSeconds (Random.Range(5f, 7f));
		Instantiate (monster, transform.position, Quaternion.identity);
		StartCoroutine (StartSpawning());
	}
}
