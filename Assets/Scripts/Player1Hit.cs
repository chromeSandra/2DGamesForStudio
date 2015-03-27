﻿using UnityEngine;
using System.Collections;

public class Player1Hit : MonoBehaviour {
	HitInTurnsManager canHit;
	public int point = 0;
	// Use this for initialization
	void Start () {
		canHit = GameObject.Find("Manager").GetComponent<HitInTurnsManager>();
	}
	
	// Update is called once per frame

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.name == "Player2" && canHit.player1hitting) {
			audio.Play();
			point +=1;
			Debug.Log ("Hit player2, Score: "+point);
		}
	}
}
