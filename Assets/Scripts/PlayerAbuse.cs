﻿using UnityEngine;
using System.Collections;

public class PlayerAbuse : MonoBehaviour {

	public float maxAbuse = 100.0f;
	public float curAbuse = 0.0f;
	public GameObject abuseBar;

	// Use this for initialization
	void Start () {
		curAbuse = maxAbuse;  
	}
	
	// Update is called once per frame
	void Update () {
		float abuse_calc = curAbuse / maxAbuse;
		SetAbuseBar (abuse_calc);
	}

	public void TakeAbuse (float amount) {
		curAbuse -= amount;

		if (curAbuse <= 0.0f) {
			AudioSource deathScream = gameObject.GetComponent<AudioSource> ();
			deathScream.Play ();
			curAbuse = 0.0f;
		}

		else if (curAbuse >= maxAbuse) {
			curAbuse = maxAbuse;
		}
	}

	void SetAbuseBar(float abuse) {
		abuseBar.transform.localScale = new Vector3 (abuse,abuseBar.transform.localScale.y,abuseBar.transform.localScale.z);
	}

}