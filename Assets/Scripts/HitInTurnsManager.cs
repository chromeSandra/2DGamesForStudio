using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HitInTurnsManager : MonoBehaviour {
	public bool player1hitting;
	public int maxScore;
	private bool end = false;
	private float startTime;
	private float hitTime;
	private float lastHittime;
	public float maxHittime;
	Text player1Time;
	Text player2Time;
	Text player1Win;
	Text player2Win;
	Player1Hit player1Script;
	Player2Hit player2Script;
	GameObject Player1;
	GameObject Player2;


	// Use this for initialization
	void Start () {
		lastHittime = startTime;
		startTime = Time.time;
		Player1 = GameObject.Find("Player1");
		Player2 = GameObject.Find("Player2");
		player1Time = GameObject.Find ("Player1UI").GetComponent<Text> ();
		player2Time = GameObject.Find("Player2UI").GetComponent<Text> ();
		player1Win = GameObject.Find ("Player1Win").GetComponent<Text> ();
		player2Win = GameObject.Find("Player2Win").GetComponent<Text> ();
		player1Script = GameObject.Find("Player1").GetComponent<Player1Hit> ();
		player2Script = GameObject.Find ("Player2").GetComponent<Player2Hit> ();
	}
	
	// Update is called once per frame
	void Update () {
		hitTime = Time.time - lastHittime;

		if (player1hitting) {
			player1Time.enabled = true;
			player2Time.enabled = false;
		} else {
			player1Time.enabled = false;
			player2Time.enabled = true;
		}

		if (!end) {
			if(player1Script.point>=maxScore||player2Script.point >=maxScore){
				if(player1Script.point>=maxScore) player1Win.enabled = true;
				else player2Win.enabled = true;
				end = true;
				Destroy(Player1);
				Destroy(Player2);
			}

			if (hitTime >= maxHittime) {
				lastHittime = Time.time - startTime;
				Debug.Log(lastHittime);
				player1hitting = !player1hitting;
				Debug.Log(player1hitting);
			}
				}

  }
}