using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class End : MonoBehaviour {
	HitJudge health;
	public bool gameEnd = false;
	Text lose;
	// Use this for initialization
	void Start () {
		health = GameObject.Find ("Player").GetComponent<HitJudge> ();
		lose = GameObject.Find ("loser").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (health.health < 0) {
			gameEnd = true;
			Time.timeScale = 0;
			lose.enabled = true;
		}
	}
}
