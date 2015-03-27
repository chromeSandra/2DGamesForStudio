using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManagerPoops : MonoBehaviour {
	Text text;
	public int score;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		score = GameObject.Find ("Player1").GetComponent<EatPoops> ().score;
		Debug.Log (score);
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Time Up!  Score: " + score;
	}
}
