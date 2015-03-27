using UnityEngine;
using System.Collections;

public class PoopScript: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.name == "Player1") {
//			audio.Play();
			Destroy(gameObject);
		}
		}
	// Update is called once per frame
	void Update () {
	
	}
}
