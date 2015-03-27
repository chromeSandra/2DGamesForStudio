using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Manager : MonoBehaviour {
	public int infectObjects = 0;
	GameObject mywinner;
	GameObject loser;
	public int minInfectBuilding;
	GameTime time;
	// Use this for initialization
	// Update is called once per frame
	void Start(){
		time = GameObject.Find ("Timer").GetComponent<GameTime> ();
		mywinner = GameObject.Find ("Winner");
		loser = GameObject.Find("Loser");
	}
	void FixedUpdate () {
				if (time.gamestop) {
						if (infectObjects >= minInfectBuilding)
								mywinner.GetComponent<Text> ().enabled = true;
						else
								loser.GetComponent<Text> ().enabled = true;
				}
		}
}
