using UnityEngine;
using System.Collections;

public class Distortion : MonoBehaviour {
	Manager manager;
	Animator ani;
	private bool isCollided = false;
	void Start(){
		ani = gameObject.GetComponent<Animator> ();
		ani.enabled = false;
		manager = GameObject.Find ("Timer").GetComponent<Manager> ();
	}
	// Use this for initialization
	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "Player"&& isCollided == false) {
						ani.enabled = true;
			         isCollided = true;
			         manager.infectObjects += 1;
						Debug.Log ("Hit by player");
			audio.Play();
				}
	}
}

