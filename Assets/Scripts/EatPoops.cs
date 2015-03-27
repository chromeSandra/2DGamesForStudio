using UnityEngine;
using System.Collections;

public class EatPoops : MonoBehaviour {
	public int score;
	// Use this for initialization
	void Start () {
		score = 0;
	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Poop") {
			audio.Play();
			score +=1;
			Debug.Log(score);
		}
	}
	// Update is called once per frame
}
