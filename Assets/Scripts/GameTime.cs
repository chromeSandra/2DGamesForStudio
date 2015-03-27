using UnityEngine;
using System.Collections;

public class GameTime : MonoBehaviour {
	public bool gamestop = false;
	private float startTime;
	private float gameTime;
	public float maxGametime;
	GUIText outOfTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		gameTime = Time.time - startTime;
		if (gameTime >= maxGametime) {
			gamestop = true;	
		//	Debug.Log("Time up");
		}
	}
}
