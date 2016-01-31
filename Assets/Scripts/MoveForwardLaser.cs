﻿using UnityEngine;
using System.Collections;

public class MoveForwardLaser : MonoBehaviour {

	public float speed = 40.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		LineRenderer beam;

		transform.position += transform.forward * speed * Time.deltaTime;
		beam = gameObject.GetComponent<LineRenderer> ();
		beam.SetPosition (0, transform.position);
		beam.SetPosition (1, transform.position + transform.forward * 10.0f);
	}
}