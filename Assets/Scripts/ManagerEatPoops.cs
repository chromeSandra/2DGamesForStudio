using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ManagerEatPoops : MonoBehaviour {
	public int playerScore;
	public int minScore;
	public int missedScore;
	Text scoreText;
	GameTime stop;
	void Start () {
		playerScore = GameObject.Find("Player1").GetComponent<EatPoops>().score;
		stop = GameObject.Find ("Manager").GetComponent<GameTime> ();
		scoreText = GameObject.Find ("Score").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (stop.gamestop) {
			scoreText.enabled = true;
						Time.timeScale = 0.0f;
			Debug.Log(Time.timeScale);
						if (playerScore >= minScore) {
								Application.LoadLevel (Application.loadedLevel + 1);
								missedScore = 4 - playerScore;
						}
				}
	}
}
